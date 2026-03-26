namespace LOODIprojekt
{
    partial class Form5
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
            Datum = new DateTimePicker();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            NaseZivotinje = new ListBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // Datum
            // 
            Datum.Location = new Point(139, 162);
            Datum.Name = "Datum";
            Datum.Size = new Size(172, 23);
            Datum.TabIndex = 0;
            Datum.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 65);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Ime Udomitelja:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 116);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 4;
            label2.Text = "Kontakt podaci:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 168);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 5;
            label3.Text = "Datum udomljivanja";
            // 
            // button1
            // 
            button1.Location = new Point(541, 397);
            button1.Name = "button1";
            button1.Size = new Size(200, 100);
            button1.TabIndex = 6;
            button1.Text = "Udomi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NaseZivotinje
            // 
            NaseZivotinje.FormattingEnabled = true;
            NaseZivotinje.ItemHeight = 15;
            NaseZivotinje.Location = new Point(373, 71);
            NaseZivotinje.Name = "NaseZivotinje";
            NaseZivotinje.Size = new Size(346, 289);
            NaseZivotinje.TabIndex = 7;
            NaseZivotinje.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 53);
            label4.Name = "label4";
            label4.Size = new Size(260, 15);
            label4.TabIndex = 8;
            label4.Text = "Kliknite dva puta na životinju koju želite udomiti";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_479765495_Zxt2juDUCoiCWfdkBwu9H3mgsgedATYl;
            ClientSize = new Size(791, 528);
            Controls.Add(label4);
            Controls.Add(NaseZivotinje);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Datum);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker Datum;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button button1;
        private ListBox NaseZivotinje;
        private Label label4;
    }
}