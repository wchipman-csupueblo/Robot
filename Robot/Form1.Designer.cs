namespace Robot
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
            lblPosition = new Label();
            panel1 = new Panel();
            lblRobot = new Label();
            btnGo1 = new Button();
            btnN = new Button();
            btnW = new Button();
            btnE = new Button();
            btnS = new Button();
            btnGo10 = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(36, 11);
            lblPosition.Margin = new Padding(2, 0, 2, 0);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(60, 15);
            lblPosition.TabIndex = 0;
            lblPosition.Text = "{X=0,Y=0}";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblRobot);
            panel1.Location = new Point(31, 31);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 220);
            panel1.TabIndex = 1;
            // 
            // lblRobot
            // 
            lblRobot.BackColor = SystemColors.ControlLight;
            lblRobot.Font = new Font("Wingdings", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRobot.ForeColor = SystemColors.ActiveCaptionText;
            lblRobot.Location = new Point(100, 100);
            lblRobot.Margin = new Padding(2, 0, 2, 0);
            lblRobot.Name = "lblRobot";
            lblRobot.Size = new Size(20, 20);
            lblRobot.TabIndex = 0;
            lblRobot.Text = "a";
            lblRobot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGo1
            // 
            btnGo1.Location = new Point(54, 278);
            btnGo1.Margin = new Padding(2);
            btnGo1.Name = "btnGo1";
            btnGo1.Size = new Size(48, 20);
            btnGo1.TabIndex = 2;
            btnGo1.Text = "Go &1";
            btnGo1.UseVisualStyleBackColor = true;
            // 
            // btnN
            // 
            btnN.Location = new Point(127, 260);
            btnN.Margin = new Padding(2);
            btnN.Name = "btnN";
            btnN.Size = new Size(24, 20);
            btnN.TabIndex = 3;
            btnN.Text = "&N";
            btnN.UseVisualStyleBackColor = true;
            // 
            // btnW
            // 
            btnW.Location = new Point(106, 278);
            btnW.Margin = new Padding(2);
            btnW.Name = "btnW";
            btnW.Size = new Size(24, 20);
            btnW.TabIndex = 4;
            btnW.Text = "&W";
            btnW.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            btnE.Location = new Point(149, 278);
            btnE.Margin = new Padding(2);
            btnE.Name = "btnE";
            btnE.Size = new Size(24, 20);
            btnE.TabIndex = 5;
            btnE.Text = "&E";
            btnE.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            btnS.Location = new Point(127, 297);
            btnS.Margin = new Padding(2);
            btnS.Name = "btnS";
            btnS.Size = new Size(24, 20);
            btnS.TabIndex = 6;
            btnS.Text = "&S";
            btnS.UseVisualStyleBackColor = true;
            // 
            // btnGo10
            // 
            btnGo10.Location = new Point(177, 278);
            btnGo10.Margin = new Padding(2);
            btnGo10.Name = "btnGo10";
            btnGo10.Size = new Size(48, 20);
            btnGo10.TabIndex = 7;
            btnGo10.Text = "&Go 10";
            btnGo10.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(176, 334);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(284, 376);
            Controls.Add(btnExit);
            Controls.Add(btnGo10);
            Controls.Add(btnS);
            Controls.Add(btnE);
            Controls.Add(btnW);
            Controls.Add(btnN);
            Controls.Add(btnGo1);
            Controls.Add(panel1);
            Controls.Add(lblPosition);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Robot";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPosition;
        private Panel panel1;
        private Label lblRobot;
        private Button btnGo1;
        private Button btnN;
        private Button btnW;
        private Button btnE;
        private Button btnS;
        private Button btnGo10;
        private Button btnExit;
    }
}