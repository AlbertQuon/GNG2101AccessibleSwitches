using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private int delay = 1;
        private int switchDelay = 2;
        private double delayText = 1;
        public Form1() {
            InitializeComponent();
            init();
            cursorMove();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            label1.Text = (speed * 50).ToString();
            label3.Text = (delayText).ToString();
            label8.Text = switchDelay.ToString();
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
            if (delay < 3000) {
                delay += 250;
                delayText = delay / 1000.0;
                label3.Text = (delayText).ToString();
                port.Write(delay.ToString());
            }
        }
        private void button4_MouseClick(object sender, MouseEventArgs e) {
            if (delay > 1000) {
                delay -= 250;
                delayText = delay / 1000.0;
                label3.Text = (delayText).ToString();
                port.Write(delay.ToString());
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
                } catch (Exception e) {
                    port.Close();
                }
            }
            if (!port.IsOpen) { // open the port to communicate with the arduino
                try {
                    port.Open();
                } catch (System.IO.IOException e) {
                    System.Windows.Forms.MessageBox.Show("Invalid port!");
                }
                port.DtrEnable = true;
            }
        }

        private async Task cursorMove() {
            int mode = 1; // initial mode, start moving the cursor
            Cursor cursor = new Cursor(Cursor.Current.Handle);
            int maxX = Screen.PrimaryScreen.Bounds.Width - 1;
            int maxY = Screen.PrimaryScreen.Bounds.Height - 1;
            Boolean left = false;
            Boolean up = false;
            Boolean clicked = false;
            int currentTime = DateTime.Now.Second;
            while (true) {

                //Console.WriteLine(port.ReadExisting());
                if (port.ReadExisting().Equals("switch")) {
                    mode--;
                    clicked = false;
                    mode = mode-1 < 1 ? 5 : mode-1;
                }

                if (DateTime.Now.Second - currentTime >= switchDelay) {
                    currentTime = DateTime.Now.Second;
                    mode = mode+1 > 5 ? 1 : mode+1;
                    clicked = false;
                }
                Console.WriteLine(mode);
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
                    //case (4):
                     //   if (!clicked) {
                     //       mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                     //       clicked = true;
                     //   }
                     //   break;
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

        private void button5_Click(object sender, EventArgs e) {
            if (switchDelay < 5) {
                switchDelay += 1;
                label3.Text = delay.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            if (switchDelay > 1) {
                switchDelay += 1;
                label3.Text = delay.ToString();
            }
        }

        private void CreateShortcut() {
        }


    }
}
