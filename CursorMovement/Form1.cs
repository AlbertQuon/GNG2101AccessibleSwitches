﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        static SerialPort port;

        private int speed = 2;
        private int delay = 1000;
        private int switchDirectionDelay = 2000;
        private Form2 form2 = null;
        public Form1() {
            InitializeComponent();
            init();
            cursorMove();
        }

        // GUI ***************************************************************************************************
        private void button1_Click(object sender, EventArgs e) {
            if (speed < 6) {
                speed += 1;
                speedText.Text = (speed * 50).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (speed > 1) {
                speed -= 1;
                speedText.Text = (speed * 50).ToString();
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e) {
            if (delay < 5000) {
                delay += 250;
                inputDelayText.Text = string.Format("{0:N2}", (delay - 1) / 1000.00);
                port.Write(delay.ToString());
            }
        }
        private void button4_MouseClick(object sender, MouseEventArgs e) {
            if (delay > 500) {
                delay -= 250;
                inputDelayText.Text = string.Format("{0:N2}", (delay - 1) / 1000.00);
                port.Write(delay.ToString());
            }
        }
        private void button5_Click(object sender, EventArgs e) {
            if (switchDirectionDelay < 5000) {
                switchDirectionDelay += 200;
                directionDelayText.Text = string.Format("{0:N2}", (switchDirectionDelay - 1) / 1000.00);
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            if (switchDirectionDelay > 1000) {
                switchDirectionDelay -= 200;
                directionDelayText.Text = string.Format("{0:N2}", (switchDirectionDelay - 1) / 1000.00); ;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            if (form2.IsDisposed) {
                form2 = new Form2();
                form2.Show();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            saveSettings();
        }
        private void Form1_Load(object sender, EventArgs e) {
            loadSettings();
            speedText.Text = (speed * 50).ToString();
            inputDelayText.Text = string.Format("{0:N2}", (delay - 1) / 1000.00);
            directionDelayText.Text = string.Format("{0:N2}", (switchDirectionDelay - 1) / 1000.00);
        }
        // Functions ***************************************************************************************************
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
            loadSettings();
            form2 = new Form2();
            form2.Show();
            port.Write(delay.ToString());

        }


        private void loadSettings() {
            string currDir = Path.GetDirectoryName(Application.ExecutablePath);
            string path = currDir + "\\settings.txt";

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("cursorSpeed(pixel/second)=" + speed.ToString());
                    sw.WriteLine("switchDelay(milliseconds)=" + delay.ToString());
                    sw.WriteLine("directionTimeChange(seconds)=" + switchDirectionDelay.ToString());
                }
            } else {
                using (StreamReader sr = File.OpenText(path)) {
                    string s;
                    string[] setting;
                    try {
                        while ((s = sr.ReadLine()) != null) {
                            setting = s.Split('=');
                            if (setting[0].Equals("cursorSpeed(pixel/second)")) {
                                speed = Int32.Parse(setting[1]);
                            }
                            if (setting[0].Equals("switchDelay(milliseconds)")) {
                                delay = Int32.Parse(setting[1]);
                            }
                            if (setting[0].Equals("directionTimeChange(milliseconds)")) {
                                switchDirectionDelay = Int32.Parse(setting[1]);
                            }
                        }
                    } catch (Exception e) {
                        MessageBox.Show("Error reading settings");
                    }
                }
            }

        }

        private void saveSettings() {
            string currDir = Path.GetDirectoryName(Application.ExecutablePath);
            string path = currDir + "\\settings.txt";
            using (StreamWriter sw = File.CreateText(path)) {
                sw.WriteLine("cursorSpeed(pixel/second)=" + speed.ToString());
                sw.WriteLine("switchDelay(milliseconds)=" + delay.ToString());
                sw.WriteLine("directionTimeChange(milliseconds)=" + switchDirectionDelay.ToString());
            }

        }


        private async Task cursorMove() {
            int mode = 1, nextMode = 2; // initial mode, start moving the cursor
            Cursor cursor = new Cursor(Cursor.Current.Handle);
            int maxX = Screen.PrimaryScreen.Bounds.Width - 1;
            int maxY = Screen.PrimaryScreen.Bounds.Height - 1;
            Boolean select = false;
            Boolean clicked = false;
            var stopWatch = new Stopwatch();

            while (true) {

                var stringIn = port.ReadExisting();
                if (stringIn.Equals("switch")) {
                    select = !select;
                    if (clicked) {
                        clicked = !clicked;
                    }
                    Console.WriteLine("switch");
                }

                if (!select) {
                    mode = nextMode;
                    switch (mode) {
                        case (1): // right
                            if (Cursor.Position.X < maxX - 5) {
                                Cursor.Position = new Point(Cursor.Position.X + speed, Cursor.Position.Y);
                            }
                            break;
                        case (2):// up
                            if (Cursor.Position.Y > 5) {
                                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - speed);
                            }
                            break;
                        case (3):// left
                            if (Cursor.Position.X > 5) {
                                Cursor.Position = new Point(Cursor.Position.X - speed, Cursor.Position.Y);
                            }
                            break;
                        case (4): // down
                            if (Cursor.Position.Y < maxY - 5) {
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

                } else {
                    stopWatch.Stop();

                    if (stopWatch.ElapsedMilliseconds >= switchDirectionDelay) {
                        nextMode = nextMode == 6 ? 1 : nextMode + 1;
                        form2.updateForm(nextMode);
                        stopWatch.Restart();
                    } else {
                        stopWatch.Start();
                    }
                }
                await Task.Delay(15);
            }

            port.Close();




        }





    }
}


