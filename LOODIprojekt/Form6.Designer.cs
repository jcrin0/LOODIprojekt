namespace LOODIprojekt
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statistika = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // statistika
            // 
            statistika.FormattingEnabled = true;
            statistika.ItemHeight = 15;
            statistika.Location = new Point(12, 27);
            statistika.Name = "statistika";
            statistika.Size = new Size(364, 259);
            statistika.TabIndex = 0;
            statistika.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Statistika";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._61tKtatJQfL__AC_UF1000_1000_QL80_;
            ClientSize = new Size(992, 614);
            Controls.Add(label1);
            Controls.Add(statistika);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox statistika;
        private Label label1;
    }
}