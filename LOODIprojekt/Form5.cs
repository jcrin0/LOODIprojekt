using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                NaseZivotinje.Items.Add(s.Replace("|", " "));

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NaseZivotinje.Items.RemoveAt(i);
            string zapis = textBox1.Text + "|" + textBox2.Text + "|" + Datum.Text;
            Admin.UnosUdomitelja(zapis);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            i = NaseZivotinje.SelectedIndex;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
