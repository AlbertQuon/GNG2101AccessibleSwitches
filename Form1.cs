using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.Reflection;
using System.IO.Ports;

namespace Sensibility_Adjustment
{
    public partial class Form1 : Form
    {
        private SerialPort arduinoPort;
        int rangeCounter = 50;
        int delayCounter = 5;
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = rangeCounter.ToString();
            label3.Text = delayCounter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rangeCounter == 95)
            {
                rangeCounter = 95;
                label1.Text = rangeCounter.ToString();
                arduinoPort.WriteLine(rangeCounter.ToString());
            }
            else
            {
                rangeCounter = rangeCounter + 5;
                label1.Text = rangeCounter.ToString();
                arduinoPort.WriteLine(rangeCounter.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rangeCounter == 5)
            {
                rangeCounter = 5;
                label1.Text = rangeCounter.ToString();
                arduinoPort.WriteLine(rangeCounter.ToString());
            }
            else
            {
                rangeCounter = rangeCounter - 5;
                label1.Text = rangeCounter.ToString();
                arduinoPort.WriteLine(rangeCounter.ToString());
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            if (delayCounter == 10)
            {
                delayCounter = 10;
                label3.Text = delayCounter.ToString();
                arduinoPort.WriteLine(delayCounter.ToString());
            }
            else
            {
                delayCounter = delayCounter + 1;
                label3.Text = delayCounter.ToString();
                arduinoPort.WriteLine(delayCounter.ToString());
            }
        }
        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            if (delayCounter == 1)
            {
                delayCounter = 1;
                label3.Text = delayCounter.ToString();
                arduinoPort.WriteLine(delayCounter.ToString());
            }
            else
            {
                delayCounter = delayCounter - 1;
                label3.Text = delayCounter.ToString();
                arduinoPort.WriteLine(delayCounter.ToString());
            }
        }


        private void init()
        {
            arduinoPort = new SerialPort();
            arduinoPort.BaudRate = 9600;
            arduinoPort.PortName = "COM4"; //could change depending on which port is being used
            arduinoPort.Open();
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateShortcut()
        {
            /**
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop);
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "New shortcut for a Notepad";
            shortcut.Hotkey = "Ctrl+Shift+N";
            shortcut.TargetPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            shortcut.Save();
            */
        }

        
    }
}
