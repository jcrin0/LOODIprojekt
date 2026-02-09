namespace LOODIprojekt
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
            button7 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button7
            // 
            button7.ForeColor = SystemColors.HotTrack;
            button7.Location = new Point(495, 141);
            button7.Name = "button7";
            button7.Size = new Size(200, 100);
            button7.TabIndex = 12;
            button7.Text = "Izlaz";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.ForeColor = SystemColors.HotTrack;
            button5.Location = new Point(495, 12);
            button5.Name = "button5";
            button5.Size = new Size(200, 100);
            button5.TabIndex = 11;
            button5.Text = "Statistika";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.HotTrack;
            button4.Location = new Point(256, 141);
            button4.Name = "button4";
            button4.Size = new Size(200, 100);
            button4.TabIndex = 10;
            button4.Text = "Udomljavanje";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.HotTrack;
            button3.Location = new Point(256, 12);
            button3.Name = "button3";
            button3.Size = new Size(200, 100);
            button3.TabIndex = 9;
            button3.Text = "Filtriranje";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.HotTrack;
            button2.Location = new Point(12, 141);
            button2.Name = "button2";
            button2.Size = new Size(200, 100);
            button2.TabIndex = 8;
            button2.Text = "Pregled";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(200, 100);
            button1.TabIndex = 7;
            button1.Text = "Unos Životinje";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Snimka_zaslona_2026_02_09_125459;
            ClientSize = new Size(696, 419);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button7;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
