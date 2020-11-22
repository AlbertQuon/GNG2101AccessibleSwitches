using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursorMovement {
    public partial class Form2 : Form {
        private Form mainForm = null;
        public Form2() {
            InitializeComponent();
            this.TopMost = true;
            this.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height / 2);
        }

        public void updateForm(int mode) {
            label1_Update(mode);
        }
        private void label1_Update(int mode) {
            switch (mode) {
                case (1):
                case (6):
                    label1.Text = "→";
                    break;
                case (2):
                case (7):
                    label1.Text = "↑";
                    break;
                case (3):
                case (8):
                    label1.Text = "←";
                    break;
                case (4):
                case (9):
                    label1.Text = "↓";
                    break;
                case (5):
                    label1.Text = "L+🖱";
                    break;
                case (10):
                    label1.Text = "R+🖱";
                    break;
            }
        }
    }
}
