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


        private void Form2_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        public void updateForm(int mode) {
            label1_Update(mode);
        }
        private void label1_Update(int mode) {
            switch (mode) {
                case (1):
                    label1.Text = "→";
                    break;
                case (2):
                    label1.Text = "↑";
                    break;
                case (3):
                    label1.Text = "←";
                    break;
                case (4):
                    label1.Text = "↓";
                    break;
                case (5):
                    label1.Text = "L+🖱";
                    break;
                case (6):
                    label1.Text = "R+🖱";
                    break;
            }
        }
    }
}
