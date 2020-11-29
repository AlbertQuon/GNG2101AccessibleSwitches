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
            this.rightClickEnable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // speedText
            // 
            this.speedText.AccessibleName = "50";
            this.speedText.AutoSize = true;
            this.speedText.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.speedText.Location = new System.Drawing.Point(36, 102);
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
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(224, 99);
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
            this.inputDelayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.inputDelayText.Location = new System.Drawing.Point(410, 105);
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
            this.speedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.speedTitle.Location = new System.Drawing.Point(91, 22);
            this.speedTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedTitle.Name = "speedTitle";
            this.speedTitle.Size = new System.Drawing.Size(158, 53);
            this.speedTitle.TabIndex = 8;
            this.speedTitle.Text = "Speed";
            this.speedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputDelayTitle
            // 
            this.inputDelayTitle.AutoSize = true;
            this.inputDelayTitle.Font = new System.Drawing.Font("Arial", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDelayTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.inputDelayTitle.Location = new System.Drawing.Point(379, 22);
            this.inputDelayTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputDelayTitle.Name = "inputDelayTitle";
            this.inputDelayTitle.Size = new System.Drawing.Size(327, 53);
            this.inputDelayTitle.TabIndex = 9;
            this.inputDelayTitle.Text = "Input Delay (s)";
            // 
            // reduceInputDelayBtn
            // 
            this.reduceInputDelayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.reduceInputDelayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduceInputDelayBtn.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduceInputDelayBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.reduceInputDelayBtn.Image = global::CursorMovement.Properties.Resources.icons8_minus_100__1_;
            this.reduceInputDelayBtn.Location = new System.Drawing.Point(409, 244);
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
            this.increaseInputDelayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.increaseInputDelayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseInputDelayBtn.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increaseInputDelayBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.increaseInputDelayBtn.Image = global::CursorMovement.Properties.Resources.icons8_plus_100;
            this.increaseInputDelayBtn.Location = new System.Drawing.Point(523, 237);
            this.increaseInputDelayBtn.Margin = new System.Windows.Forms.Padding(2);
            this.increaseInputDelayBtn.Name = "increaseInputDelayBtn";
            this.increaseInputDelayBtn.Size = new System.Drawing.Size(134, 117);
            this.increaseInputDelayBtn.TabIndex = 4;
            this.increaseInputDelayBtn.UseVisualStyleBackColor = false;
            this.increaseInputDelayBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button3_MouseClick);
            // 
            // reduceSpeedBtn
            // 
            this.reduceSpeedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.reduceSpeedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduceSpeedBtn.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduceSpeedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.reduceSpeedBtn.Image = global::CursorMovement.Properties.Resources.icons8_minus_100__1_;
            this.reduceSpeedBtn.Location = new System.Drawing.Point(55, 241);
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
            this.increaseSpeedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.increaseSpeedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseSpeedBtn.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increaseSpeedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.increaseSpeedBtn.Image = global::CursorMovement.Properties.Resources.icons8_plus_100;
            this.increaseSpeedBtn.Location = new System.Drawing.Point(185, 236);
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
            this.directionTimerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.directionTimerTitle.Location = new System.Drawing.Point(722, 22);
            this.directionTimerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.directionTimerTitle.Name = "directionTimerTitle";
            this.directionTimerTitle.Size = new System.Drawing.Size(340, 53);
            this.directionTimerTitle.TabIndex = 10;
            this.directionTimerTitle.Text = "Timer Delay (s)";
            // 
            // directionDelayText
            // 
            this.directionDelayText.AccessibleName = "50";
            this.directionDelayText.AutoSize = true;
            this.directionDelayText.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionDelayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.directionDelayText.Location = new System.Drawing.Point(772, 103);
            this.directionDelayText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.directionDelayText.Name = "directionDelayText";
            this.directionDelayText.Size = new System.Drawing.Size(231, 107);
            this.directionDelayText.TabIndex = 11;
            this.directionDelayText.Text = "2.00";
            // 
            // increaseDirDelayBtn
            // 
            this.increaseDirDelayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.increaseDirDelayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseDirDelayBtn.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increaseDirDelayBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.increaseDirDelayBtn.Image = global::CursorMovement.Properties.Resources.icons8_plus_100;
            this.increaseDirDelayBtn.Location = new System.Drawing.Point(907, 238);
            this.increaseDirDelayBtn.Margin = new System.Windows.Forms.Padding(2);
            this.increaseDirDelayBtn.Name = "increaseDirDelayBtn";
            this.increaseDirDelayBtn.Size = new System.Drawing.Size(134, 117);
            this.increaseDirDelayBtn.TabIndex = 12;
            this.increaseDirDelayBtn.UseVisualStyleBackColor = false;
            this.increaseDirDelayBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // decreaseDirDelayBtn
            // 
            this.decreaseDirDelayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.decreaseDirDelayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decreaseDirDelayBtn.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decreaseDirDelayBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.decreaseDirDelayBtn.Image = global::CursorMovement.Properties.Resources.icons8_minus_100__1_;
            this.decreaseDirDelayBtn.Location = new System.Drawing.Point(762, 246);
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
            this.openNextMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.openNextMove.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.openNextMove.Location = new System.Drawing.Point(767, 394);
            this.openNextMove.Name = "openNextMove";
            this.openNextMove.Size = new System.Drawing.Size(264, 26);
            this.openNextMove.TabIndex = 14;
            this.openNextMove.TabStop = true;
            this.openNextMove.Text = "Open Next Move Indicator";
            this.openNextMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openNextMove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // rightClickEnable
            // 
            this.rightClickEnable.AutoSize = true;
            this.rightClickEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rightClickEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rightClickEnable.Location = new System.Drawing.Point(47, 392);
            this.rightClickEnable.Name = "rightClickEnable";
            this.rightClickEnable.Size = new System.Drawing.Size(342, 30);
            this.rightClickEnable.TabIndex = 15;
            this.rightClickEnable.Text = "Add Extra Right Click Sequence";
            this.rightClickEnable.UseVisualStyleBackColor = true;
            this.rightClickEnable.CheckedChanged += new System.EventHandler(this.rightClickEnable_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1081, 436);
            this.Controls.Add(this.rightClickEnable);
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
        private CheckBox rightClickEnable;
    }
}

