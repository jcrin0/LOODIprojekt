    using System;
using System.Collections;
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
        public static List<string> Ucitaj()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("animals.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                lista.Add(linija);
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;
        }
        public static List<string> FilterVrsta()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("animals.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                string[] dijelovi = linija.Split('|');
                string vrsta = dijelovi[1];
                lista.Add(vrsta);
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;
        }
        public static List<string> Vrste()
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("animals.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                string[] dijelovi = linija.Split('|');
                string vrsta = dijelovi[1];
                lista.Add(vrsta);
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;
        }

        public static List<string> PronadiPoVrsti(string kriterij)
        {
            List<string> lista = new List<string>();
            StreamReader sr = new StreamReader("animals.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                string[] dijelovi = linija.Split('|');
                if (dijelovi[1] == kriterij)
                {
                    lista.Add(linija);
                }
                linija = sr.ReadLine();
            }
            sr.Close();
            return lista;


        }
        public static void UnosUdomitelja(string zapis)
        {
            StreamWriter sw = new StreamWriter("udomitelji.txt", true);
            sw.WriteLine(zapis);
            sw.Close();


        }
    }
}
