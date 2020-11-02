using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;

namespace CursorMovement {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        static SerialPort port;
        static async Task Main() {
            port = new SerialPort("COM3", 115200); // may need to be changed based on computer configuration (port, baud rate)
            
            if (!port.IsOpen) { // open the port to communicate with the arduino
                port.Open();
                port.DtrEnable = true;
            }
            int mode = 1; // initial mode, start moving the cursor
            Cursor cursor = new Cursor(Cursor.Current.Handle);
            int maxX = Screen.PrimaryScreen.Bounds.Width - 1;
            int maxY = Screen.PrimaryScreen.Bounds.Height - 1;
            Boolean left = false;
            Boolean up = false;
            Boolean clicked = false;
            int xSpeed = 2, ySpeed = 2;
            
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
                            Cursor.Position = new Point(Cursor.Position.X + xSpeed, Cursor.Position.Y);
                        }
                        if (left) {
                            Cursor.Position = new Point(Cursor.Position.X - xSpeed, Cursor.Position.Y);
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
                            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + ySpeed);
                        }
                        if (!up) {
                            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - ySpeed);
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
                await Task.Delay(10);
            }
            
            port.Close();

            

        }
        

    }
}
