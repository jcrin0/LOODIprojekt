using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOODIprojekt
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                const string path = "animals.txt";

                if (!File.Exists(path))
                {
                    MessageBox.Show("Nema zapisa za prikaz.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var lines = File.ReadAllLines(path, Encoding.UTF8);
                foreach (var line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                        listBox1.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čitanju zapisa: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
