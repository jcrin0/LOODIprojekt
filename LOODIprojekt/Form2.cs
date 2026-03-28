using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace LOODIprojekt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string slika = openFileDialog1.FileName;
            pictureBox1.Load(slika);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string slika = openFileDialog1.FileName;
            string spol = "";
            string kast = "";
            if (checkBox2.Checked == true)
            {
                kast = "kastriran";
            }
            else
            {
                kast = "Nije kastriran";
            }
            string cijep = "";
            if (checkBox1.Checked == true)
            {
                cijep = "cijepljen";
            }
            else
            {
                cijep = "Nije cijepljen";
            }
            if (radioButton1.Checked == true)
            {
                spol = "Muško";
            }
            else if (radioButton2.Checked == true)
            {
                spol = "Žensko";
            }
            string zapis = textBox3.Text + "|" + textBox4.Text + "|" + textBox2.Text + "|" + spol + "|" + numericUpDown1.Text + "|" + dateTimePicker1.Text + "|" + cijep + "|" + kast + "|" + textBox1.Text + "|" + slika;
            Admin.UnosZivotinje(zapis);
            textBox3.Clear();
            textBox4.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            numericUpDown1.Value = 0;
            dateTimePicker1.Value = DateTime.Now;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            textBox1.Clear();
            pictureBox1.Image = null;

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
