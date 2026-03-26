using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            string slika = openFileDialog1.FileName;
            
            string kast = "";

            string spol;
            if (radioButton1.Checked)
            {
                spol = "M";
            }
            else if (radioButton2.Checked)
            {
                spol = "Ž";
            }
            else
            {
                MessageBox.Show("Odaberite spol životinje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBox1.Checked == true)
            {
                kast = "kastriran";
            }
            else
            {
                kast = "Nije kastriran";
            }
            string cijep = "";
            if (checkBox2.Checked == true)
            {
                cijep = "cijepljen";
            }
            else
            {
                cijep = "Nije cijepljen";
            }



            string zapis = textBox3.Text + "|" + textBox4.Text + "|" + textBox2.Text + "|" +
                           spol + "|" + numericUpDown1.Value + "|" + dateTimePicker1.Text + "|" +
                           kast + "|" + cijep + "|" + textBox1.Text;


            Admin.SaveAnimal(zapis);

            MessageBox.Show("Životinja je spremljena.");


            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            numericUpDown1.Value = numericUpDown1.Minimum;
            dateTimePicker1.Value = DateTime.Now;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string slika = openFileDialog1.FileName;
            pictureBox1.Load(slika);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
