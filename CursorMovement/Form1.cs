using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
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
        private int delay = 20;
        public Form1() {
            InitializeComponent();
            init();
            cursorMove();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            label1.Text = (speed * 50).ToString();
            label3.Text = delay.ToString();
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
            if (delay < 500) {
                delay += 20;
                label3.Text = delay.ToString();
            }
        }
        private void button4_MouseClick(object sender, MouseEventArgs e) {
            if (delay > 20) {
                delay -= 20;
                label3.Text = delay.ToString();

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
            
            while (true) {

                //Console.WriteLine(port.ReadExisting());
                if (port.ReadExisting().Equals("switch")) {
                    mode++;
                    clicked = false;
                    if (mode > 4) { mode = 1; }
                }

                switch (mode) {
                    case (1):
                        if (!left) {
                            Cursor.Position = new Point(Cursor.Position.X + speed, Cursor.Position.Y);
                        }
                        if (left) {
                            Cursor.Position = new Point(Cursor.Position.X - speed, Cursor.Position.Y);
                        }
                        if (Cursor.Position.X > maxX - 5) {
                            left = true;
                        }
                        if (Cursor.Position.X < 5) {
                            left = false;
                        }
                        break;
                    case (2):
                        if (up) {
                            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + speed);
                        }
                        if (!up) {
                            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - speed);
                        }
                        if (Cursor.Position.Y > maxY - 5) {
                            up = false;
                        }
                        if (Cursor.Position.Y < 5) {
                            up = true;
                        }
                        break;
                    case (3):
                        if (!clicked) {
                            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                            clicked = true;
                        }
                        break;
                    case (4):
                        if (!clicked) {
                            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                            clicked = true;
                        }
                        break;
                }
                await Task.Delay(delay);
            }

            port.Close();



        
        }

        private void label1_Paint(object sender, PaintEventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void CreateShortcut() {
        }


    }
}
