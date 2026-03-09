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
    public partial class Form4 : Form
    {
        private const string DataFile = "animals.txt";

        public Form4()
        {
            InitializeComponent();
            PopulateFilterCombo();
        }

        private void PopulateFilterCombo()
        {
            comboBox1.Items.Clear();

            // Base filter options
            comboBox1.Items.Add("Sve");
            comboBox1.Items.Add("Cijepljen");
            comboBox1.Items.Add("Kastriran");

            // Add distinct species/types from the data file
            try
            {
                if (File.Exists(DataFile))
                {
                    var types = File.ReadAllLines(DataFile, Encoding.UTF8)
                                    .Where(l => !string.IsNullOrWhiteSpace(l))
                                    .Select(l => l.Split(','))
                                    .Where(p => p.Length > 1)
                                    .Select(p => p[1].Trim())
                                    .Where(s => !string.IsNullOrEmpty(s))
                                    .Distinct(StringComparer.InvariantCultureIgnoreCase)
                                    .OrderBy(s => s);

                    foreach (var t in types)
                        comboBox1.Items.Add(t);
                }
            }
            catch
            {
                // ignore file read errors; comboBox still has base options
            }

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = comboBox1.Text ?? "Sve";

            // Try to find an open Form3; if not open, create and show it
            var frm3 = Application.OpenForms.OfType<Form3>().FirstOrDefault();
            if (frm3 == null)
            {
                frm3 = new Form3();
                frm3.Show();
            }

            // Ask Form3 to apply the selected filter
            frm3.ApplyFilter(selection);
        }
    }
}
