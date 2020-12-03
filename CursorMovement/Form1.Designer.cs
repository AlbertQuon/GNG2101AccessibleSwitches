using System.Windows.Forms;

namespace CursorMovement {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.speedText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputDelayText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.speedTitle = new System.Windows.Forms.Label();
            this.inputDelayTitle = new System.Windows.Forms.Label();
            this.reduceInputDelayBtn = new System.Windows.Forms.Button();
            this.increaseInputDelayBtn = new System.Windows.Forms.Button();
            this.reduceSpeedBtn = new System.Windows.Forms.Button();
            this.increaseSpeedBtn = new System.Windows.Forms.Button();
            this.directionTimerTitle = new System.Windows.Forms.Label();
            this.directionDelayText = new System.Windows.Forms.Label();
            this.increaseDirDelayBtn = new System.Windows.Forms.Button();
            this.decreaseDirDelayBtn = new System.Windows.Forms.Button();
            this.openNextMove = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // speedText
            // 
            this.speedText.AccessibleName = "50";
            this.speedText.AutoSize = true;
            this.speedText.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedText.ForeColor = System.Drawing.Color.Black;
            this.speedText.Location = new System.Drawing.Point(40, 272);
            this.speedText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedText.Name = "speedText";
            this.speedText.Size = new System.Drawing.Size(204, 107);
            this.speedText.TabIndex = 0;
            this.speedText.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(224, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 110);
            this.label2.TabIndex = 3;
            this.label2.Text = "%";
            // 
            // inputDelayText
            // 
            this.inputDelayText.AccessibleName = "50";
            this.inputDelayText.AutoSize = true;
            this.inputDelayText.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDelayText.ForeColor = System.Drawing.Color.Black;
            this.inputDelayText.Location = new System.Drawing.Point(455, 272);
            this.inputDelayText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputDelayText.Name = "inputDelayText";
            this.inputDelayText.Size = new System.Drawing.Size(231, 107);
            this.inputDelayText.TabIndex = 6;
            this.inputDelayText.Text = "1.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(472, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // speedTitle
            // 
            this.speedTitle.AccessibleName = "Range";
            this.speedTitle.AllowDrop = true;
            this.speedTitle.AutoSize = true;
            this.speedTitle.Font = new System.Drawing.Font("Arial", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedTitle.ForeColor = System.Drawing.Color.Black;
            this.speedTitle.Location = new System.Drawing.Point(40, 40);
            this.speedTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedTitle.Name = "speedTitle";
            this.speedTitle.Size = new System.Drawing.Size(312, 53);
            this.speedTitle.TabIndex = 8;
            this.speedTitle.Text = "Mouse Speed";
            this.speedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputDelayTitle
            // 
            this.inputDelayTitle.AutoSize = true;
            this.inputDelayTitle.Font = new System.Drawing.Font("Arial", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDelayTitle.ForeColor = System.Drawing.Color.Black;
            this.inputDelayTitle.Location = new System.Drawing.Point(472, 40);
            this.inputDelayTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputDelayTitle.Name = "inputDelayTitle";
            this.inputDelayTitle.Size = new System.Drawing.Size(271, 53);
            this.inputDelayTitle.TabIndex = 9;
            this.inputDelayTitle.Text = "Delay Input ";
            // 
            // reduceInputDelayBtn
            // 
            this.reduceInputDelayBtn.BackColor = System.Drawing.Color.White;
            this.reduceInputDelayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduceInputDelayBtn.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduceInputDelayBtn.ForeColor = System.Drawing.Color.White;
            this.reduceInputDelayBtn.Image = global::CursorMovement.Properties.Resources.icons8_minus_100__1_;
            this.reduceInputDelayBtn.Location = new System.Drawing.Point(488, 408);
            this.reduceInputDelayBtn.Margin = new System.Windows.Forms.Padding(0);
            this.reduceInputDelayBtn.Name = "reduceInputDelayBtn";
            this.reduceInputDelayBtn.Size = new System.Drawing.Size(94, 102);
            this.reduceInputDelayBtn.TabIndex = 5;
            this.reduceInputDelayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reduceInputDelayBtn.UseVisualStyleBackColor = false;
            this.reduceInputDelayBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button4_MouseClick);
            // 
            // increaseInputDelayBtn
            // 
            this.increaseInputDelayBtn.BackColor = System.Drawing.Color.White;
            this.increaseInputDelayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseInputDelayBtn.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increaseInputDelayBtn.ForeColor = System.Drawing.Color.White;
            this.increaseInputDelayBtn.Image = global::CursorMovement.Properties.Resources.icons8_plus_100;
            this.increaseInputDelayBtn.Location = new System.Drawing.Point(624, 400);
            this.increaseInputDelayBtn.Margin = new System.Windows.Forms.Padding(2);
            this.increaseInputDelayBtn.Name = "increaseInputDelayBtn";
            this.increaseInputDelayBtn.Size = new System.Drawing.Size(134, 117);
            this.increaseInputDelayBtn.TabIndex = 4;
            this.increaseInputDelayBtn.UseVisualStyleBackColor = false;
            this.increaseInputDelayBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button3_MouseClick);
            // 
            // reduceSpeedBtn
            // 
            this.reduceSpeedBtn.BackColor = System.Drawing.Color.White;
            this.reduceSpeedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduceSpeedBtn.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduceSpeedBtn.ForeColor = System.Drawing.Color.White;
            this.reduceSpeedBtn.Image = global::CursorMovement.Properties.Resources.icons8_minus_100__1_;
            this.reduceSpeedBtn.Location = new System.Drawing.Point(64, 408);
            this.reduceSpeedBtn.Margin = new System.Windows.Forms.Padding(0);
            this.reduceSpeedBtn.Name = "reduceSpeedBtn";
            this.reduceSpeedBtn.Size = new System.Drawing.Size(94, 102);
            this.reduceSpeedBtn.TabIndex = 2;
            this.reduceSpeedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reduceSpeedBtn.UseVisualStyleBackColor = false;
            this.reduceSpeedBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // increaseSpeedBtn
            // 
            this.increaseSpeedBtn.BackColor = System.Drawing.Color.White;
            this.increaseSpeedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseSpeedBtn.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increaseSpeedBtn.ForeColor = System.Drawing.Color.White;
            this.increaseSpeedBtn.Image = global::CursorMovement.Properties.Resources.icons8_plus_100;
            this.increaseSpeedBtn.Location = new System.Drawing.Point(200, 400);
            this.increaseSpeedBtn.Margin = new System.Windows.Forms.Padding(2);
            this.increaseSpeedBtn.Name = "increaseSpeedBtn";
            this.increaseSpeedBtn.Size = new System.Drawing.Size(134, 117);
            this.increaseSpeedBtn.TabIndex = 1;
            this.increaseSpeedBtn.UseVisualStyleBackColor = false;
            this.increaseSpeedBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // directionTimerTitle
            // 
            this.directionTimerTitle.AutoSize = true;
            this.directionTimerTitle.Font = new System.Drawing.Font("Arial", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionTimerTitle.ForeColor = System.Drawing.Color.Black;
            this.directionTimerTitle.Location = new System.Drawing.Point(873, 42);
            this.directionTimerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.directionTimerTitle.Name = "directionTimerTitle";
            this.directionTimerTitle.Size = new System.Drawing.Size(375, 53);
            this.directionTimerTitle.TabIndex = 10;
            this.directionTimerTitle.Text = "Cycle Frequency";
            // 
            // directionDelayText
            // 
            this.directionDelayText.AccessibleName = "50";
            this.directionDelayText.AutoSize = true;
            this.directionDelayText.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionDelayText.ForeColor = System.Drawing.Color.Black;
            this.directionDelayText.Location = new System.Drawing.Point(919, 279);
            this.directionDelayText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.directionDelayText.Name = "directionDelayText";
            this.directionDelayText.Size = new System.Drawing.Size(231, 107);
            this.directionDelayText.TabIndex = 11;
            this.directionDelayText.Text = "2.00";
            // 
            // increaseDirDelayBtn
            // 
            this.increaseDirDelayBtn.BackColor = System.Drawing.Color.White;
            this.increaseDirDelayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseDirDelayBtn.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increaseDirDelayBtn.ForeColor = System.Drawing.Color.White;
            this.increaseDirDelayBtn.Image = global::CursorMovement.Properties.Resources.icons8_plus_100;
            this.increaseDirDelayBtn.Location = new System.Drawing.Point(1054, 402);
            this.increaseDirDelayBtn.Margin = new System.Windows.Forms.Padding(2);
            this.increaseDirDelayBtn.Name = "increaseDirDelayBtn";
            this.increaseDirDelayBtn.Size = new System.Drawing.Size(134, 117);
            this.increaseDirDelayBtn.TabIndex = 12;
            this.increaseDirDelayBtn.UseVisualStyleBackColor = false;
            this.increaseDirDelayBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // decreaseDirDelayBtn
            // 
            this.decreaseDirDelayBtn.BackColor = System.Drawing.Color.White;
            this.decreaseDirDelayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decreaseDirDelayBtn.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decreaseDirDelayBtn.ForeColor = System.Drawing.Color.White;
            this.decreaseDirDelayBtn.Image = global::CursorMovement.Properties.Resources.icons8_minus_100__1_;
            this.decreaseDirDelayBtn.Location = new System.Drawing.Point(937, 408);
            this.decreaseDirDelayBtn.Margin = new System.Windows.Forms.Padding(0);
            this.decreaseDirDelayBtn.Name = "decreaseDirDelayBtn";
            this.decreaseDirDelayBtn.Size = new System.Drawing.Size(94, 102);
            this.decreaseDirDelayBtn.TabIndex = 13;
            this.decreaseDirDelayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.decreaseDirDelayBtn.UseVisualStyleBackColor = false;
            this.decreaseDirDelayBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // openNextMove
            // 
            this.openNextMove.AutoSize = true;
            this.openNextMove.BackColor = System.Drawing.Color.White;
            this.openNextMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.openNextMove.LinkColor = System.Drawing.Color.RoyalBlue;
            this.openNextMove.Location = new System.Drawing.Point(480, 536);
            this.openNextMove.Name = "openNextMove";
            this.openNextMove.Size = new System.Drawing.Size(264, 26);
            this.openNextMove.TabIndex = 14;
            this.openNextMove.TabStop = true;
            this.openNextMove.Text = "Open Next Move Indicator";
            this.openNextMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openNextMove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(664, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 55);
            this.label1.TabIndex = 15;
            this.label1.Text = "sec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 36F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1128, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 55);
            this.label3.TabIndex = 16;
            this.label3.Text = "sec";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(75, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(996, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(494, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(543, 199);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1316, 573);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openNextMove);
            this.Controls.Add(this.decreaseDirDelayBtn);
            this.Controls.Add(this.increaseDirDelayBtn);
            this.Controls.Add(this.directionDelayText);
            this.Controls.Add(this.directionTimerTitle);
            this.Controls.Add(this.inputDelayTitle);
            this.Controls.Add(this.speedTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputDelayText);
            this.Controls.Add(this.reduceInputDelayBtn);
            this.Controls.Add(this.increaseInputDelayBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reduceSpeedBtn);
            this.Controls.Add(this.increaseSpeedBtn);
            this.Controls.Add(this.speedText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Switch Adjustment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedText;
        private System.Windows.Forms.Button increaseSpeedBtn;
        private System.Windows.Forms.Button reduceSpeedBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button increaseInputDelayBtn;
        private System.Windows.Forms.Button reduceInputDelayBtn;
        private System.Windows.Forms.Label inputDelayText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label speedTitle;
        private System.Windows.Forms.Label inputDelayTitle;
        private Label directionTimerTitle;
        private Label directionDelayText;
        private Button increaseDirDelayBtn;
        private Button decreaseDirDelayBtn;
        private LinkLabel openNextMove;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
    }
}

