using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOODIprojekt
{
    public static class Admin
    {
        public static void SaveAnimal(string zapis)
        {
            StreamWriter sw = new StreamWriter("animals.txt", true);
            sw.WriteLine(zapis);
            sw.Close();

        }
        public static List<string> FilterVrsta(string vrsta)
        {
            List<string> animals = new List<string>();


            return animals;
        }
    }
}
