using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursorMovement {

    public partial class Form1 : Form {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private int xSpeed = 2, ySpeed = 2;
        static SerialPort port;

        private int speed = 2;
        private int delay = 1000;
        private int switchDirectionDelay = 2;
        private Form2 form2 = null;
        private Boolean rightClickEnabled = false;
        public Form1() {
            InitializeComponent();
            init();
            cursorMove();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
        }

        private void button1_Click(object sender, EventArgs e) {
            if (speed < 6) {
                speed += 1;
                label1.Text = (speed * 50).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (speed > 1) {
                speed -= 1;
                label1.Text = (speed * 50).ToString();
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e) {
            if (delay < 5000) {
                delay += 250;
                label3.Text = string.Format("{0:N2}", (delay - 1) / 1000.00);
                port.Write(delay.ToString());
            }
        }
        private void button4_MouseClick(object sender, MouseEventArgs e) {
            if (delay > 1000) {
                delay -= 250;
                label3.Text = string.Format("{0:N2}", (delay - 1) / 1000.00);
                port.Write(delay.ToString());
            }
        }
        private void button5_Click(object sender, EventArgs e) {
            if (switchDirectionDelay < 5) {
                switchDirectionDelay += 1;
                label8.Text = switchDirectionDelay.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            if (switchDirectionDelay > 1) {
                switchDirectionDelay -= 1;
                label8.Text = switchDirectionDelay.ToString();
            }
        }


        private void init() {
            string portName;
            //port = new SerialPort("COM3", 115200);
            Console.WriteLine(String.Join("\n", SerialPort.GetPortNames()));
            foreach (string s in SerialPort.GetPortNames()) {
                portName = s;
                try {
                    port = new SerialPort(portName, 115200);
                    port.Open();
                    if (port.ReadExisting().Equals("switch")) {
                        break;
                    }
                    if (!port.IsOpen) { // open the port to communicate with the arduino
                        try {
                            port.Open();
                        } catch (System.IO.IOException e) {
                            MessageBox.Show("Invalid port!");
                        }
                        port.DtrEnable = true;
                    }
                } catch (Exception e) {
                    port.Close();
                }
            }
            if (port == null) {
                MessageBox.Show("No device found!\n Make sure the device is plugged in properly.");
                Environment.Exit(1);
                
            }
            form2 = new Form2();
            form2.Show();
            port.Write(delay.ToString());
            
        }

        private async Task cursorMove() {
            int mode = 1, nextMode = 2; // initial mode, start moving the cursor
            Cursor cursor = new Cursor(Cursor.Current.Handle);
            int maxX = Screen.PrimaryScreen.Bounds.Width - 1;
            int maxY = Screen.PrimaryScreen.Bounds.Height - 1;
            Boolean clicked = false;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            while (true) {

                var stringIn = port.ReadExisting();
                Console.WriteLine(stringIn);
                if (stringIn.Equals("switch")) {
                    mode--;
                    clicked = false;
                    if (rightClickEnabled) {
                        mode = mode - 1 < 1 ? 6 : mode - 1;
                        nextMode = mode == 6 ? 1 : mode + 1;
                    } else {
                        mode = mode - 1 < 1 ? 5 : mode - 1;
                        nextMode = mode == 5 ? 1 : mode + 1;
                    }
                    ;
                }
                stopWatch.Stop();
                if (stopWatch.ElapsedMilliseconds/1000 >= switchDirectionDelay) {
                    stopWatch.Restart();
                    
                    if (rightClickEnabled) {
                        mode = mode + 1 > 6 ? 1 : mode + 1;
                        nextMode = mode == 6 ? 1 : mode + 1;
                    } else {
                        mode = mode + 1 > 5 ? 1 : mode + 1;
                        nextMode = mode == 5 ? 1 : mode + 1;
                    }
                    clicked = false;
                } else {
                    stopWatch.Start();
                }
                form2.updateForm(nextMode);
                Console.WriteLine(mode);
                Console.WriteLine(nextMode);

                switch (mode) {
                    case (1): // right

                        if (Cursor.Position.X < maxX - 5) {
                            Cursor.Position = new Point(Cursor.Position.X + speed, Cursor.Position.Y);
                        }
                        break;
                    case (2): // up
                        if (Cursor.Position.Y > 5) {
                            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - speed);
                        }
                        break;
                    case (3): // left
                        
                        if (Cursor.Position.X > 5) {
                            Cursor.Position = new Point(Cursor.Position.X - speed, Cursor.Position.Y);
                        }
                        break;
                    case (4): // down
                        if (Cursor.Position.Y < maxY-5) {
                            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + speed);
                        }
                        break;
                    case (5):
                        if (!clicked) {
                            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                            clicked = true;
                        }
                        break;
                     case (6):
                        if (!clicked) {
                            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                        clicked = true;
                     }
                     break;
                     
                }
                
                await Task.Delay(20);
            }

            port.Close();



        
        }

        private void label1_Paint(object sender, PaintEventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }

        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            
            if (form2.IsDisposed) {
                form2 = new Form2();
                form2.Show();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (rightClickEnabled) {
                rightClickEnabled = false;
            } else {
                rightClickEnabled = true;
            }
        }

        private void CreateShortcut() {
        }


    }
}
