namespace ColorMixer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpColor1 = new GroupBox();
            rdoYellow1 = new RadioButton();
            rdoBlue1 = new RadioButton();
            rdoRed1 = new RadioButton();
            grpColor2 = new GroupBox();
            rdoYellow2 = new RadioButton();
            rdoRed2 = new RadioButton();
            rdoBlue2 = new RadioButton();
            btnMix = new Button();
            btnExit = new Button();
            grpColor1.SuspendLayout();
            grpColor2.SuspendLayout();
            SuspendLayout();
            // 
            // grpColor1
            // 
            grpColor1.Controls.Add(rdoYellow1);
            grpColor1.Controls.Add(rdoBlue1);
            grpColor1.Controls.Add(rdoRed1);
            grpColor1.Location = new Point(116, 44);
            grpColor1.Name = "grpColor1";
            grpColor1.Size = new Size(232, 194);
            grpColor1.TabIndex = 0;
            grpColor1.TabStop = false;
            grpColor1.Text = "Select the First Color";
            // 
            // rdoYellow1
            // 
            rdoYellow1.AutoSize = true;
            rdoYellow1.Location = new Point(43, 137);
            rdoYellow1.Name = "rdoYellow1";
            rdoYellow1.Size = new Size(59, 19);
            rdoYellow1.TabIndex = 2;
            rdoYellow1.TabStop = true;
            rdoYellow1.Text = "Yellow";
            rdoYellow1.UseVisualStyleBackColor = true;
            // 
            // rdoBlue1
            // 
            rdoBlue1.AutoSize = true;
            rdoBlue1.Location = new Point(43, 92);
            rdoBlue1.Name = "rdoBlue1";
            rdoBlue1.Size = new Size(48, 19);
            rdoBlue1.TabIndex = 1;
            rdoBlue1.TabStop = true;
            rdoBlue1.Text = "Blue";
            rdoBlue1.UseVisualStyleBackColor = true;
            // 
            // rdoRed1
            // 
            rdoRed1.AutoSize = true;
            rdoRed1.Location = new Point(43, 47);
            rdoRed1.Name = "rdoRed1";
            rdoRed1.Size = new Size(45, 19);
            rdoRed1.TabIndex = 0;
            rdoRed1.TabStop = true;
            rdoRed1.Text = "Red";
            rdoRed1.UseVisualStyleBackColor = true;
            // 
            // grpColor2
            // 
            grpColor2.Controls.Add(rdoYellow2);
            grpColor2.Controls.Add(rdoRed2);
            grpColor2.Controls.Add(rdoBlue2);
            grpColor2.Location = new Point(435, 44);
            grpColor2.Name = "grpColor2";
            grpColor2.Size = new Size(232, 194);
            grpColor2.TabIndex = 1;
            grpColor2.TabStop = false;
            grpColor2.Text = "Select the Second Color";
            // 
            // rdoYellow2
            // 
            rdoYellow2.AutoSize = true;
            rdoYellow2.Location = new Point(55, 137);
            rdoYellow2.Name = "rdoYellow2";
            rdoYellow2.Size = new Size(59, 19);
            rdoYellow2.TabIndex = 5;
            rdoYellow2.TabStop = true;
            rdoYellow2.Text = "Yellow";
            rdoYellow2.UseVisualStyleBackColor = true;
            // 
            // rdoRed2
            // 
            rdoRed2.AutoSize = true;
            rdoRed2.Location = new Point(55, 47);
            rdoRed2.Name = "rdoRed2";
            rdoRed2.Size = new Size(45, 19);
            rdoRed2.TabIndex = 3;
            rdoRed2.TabStop = true;
            rdoRed2.Text = "Red";
            rdoRed2.UseVisualStyleBackColor = true;
            // 
            // rdoBlue2
            // 
            rdoBlue2.AutoSize = true;
            rdoBlue2.Location = new Point(55, 92);
            rdoBlue2.Name = "rdoBlue2";
            rdoBlue2.Size = new Size(48, 19);
            rdoBlue2.TabIndex = 4;
            rdoBlue2.TabStop = true;
            rdoBlue2.Text = "Blue";
            rdoBlue2.UseVisualStyleBackColor = true;
            // 
            // btnMix
            // 
            btnMix.BackColor = Color.FromArgb(192, 255, 192);
            btnMix.Location = new Point(247, 316);
            btnMix.Name = "btnMix";
            btnMix.Size = new Size(101, 46);
            btnMix.TabIndex = 2;
            btnMix.Text = "Mix Colors";
            btnMix.UseVisualStyleBackColor = false;
            btnMix.Click += btnMix_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 192);
            btnExit.Location = new Point(434, 316);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(101, 46);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnMix);
            Controls.Add(grpColor2);
            Controls.Add(grpColor1);
            Name = "Form1";
            Text = "Form1";
            grpColor1.ResumeLayout(false);
            grpColor1.PerformLayout();
            grpColor2.ResumeLayout(false);
            grpColor2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpColor1;
        private RadioButton rdoYellow1;
        private RadioButton rdoBlue1;
        private RadioButton rdoRed1;
        private GroupBox grpColor2;
        private RadioButton rdoYellow2;
        private RadioButton rdoRed2;
        private RadioButton rdoBlue2;
        private Button btnMix;
        private Button btnExit;
    }
}