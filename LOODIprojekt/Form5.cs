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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int i = 0;
        private void Form5_Load(object sender, EventArgs e)
        {
            List<string> lista = Admin.Ucitaj();
            foreach (string s in lista)
            {
                listBox1.Items.Add(s.Replace("|", " "));

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(i);
            string zapis = textBox1.Text + "|" + textBox2 + "|" + dateTimePicker1.Text;
            Admin.UnosUdomitelja(zapis);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            i = listBox1.SelectedIndex;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
