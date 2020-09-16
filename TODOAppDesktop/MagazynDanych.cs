using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOAppDesktop.Model;

namespace TODOAppDesktop
{
    static class MagazynDanych
    {
        public static void ZapiszZadania(List<Zadanie> zadania)
        {
            var tekst = "";
            foreach (var zadanie in zadania)
            {
                tekst += zadanie.Serializuj();
                tekst += '\n';
            }

            File.WriteAllText(GetSciezkaDoPliku(), tekst);
        }

        public static List<Zadanie> OdczytajZadania()
        {
            var tekst = File.ReadAllText(GetSciezkaDoPliku());
            var listaZadan = new List<Zadanie>();

            var linijki = tekst.Split('\n');
            foreach (var linijka in linijki)
            {
                if (linijka != "")
                {
                    listaZadan.Add(Zadanie.Deserializuj(linijka));
                }
            }

            return listaZadan;
        }

        public static void ZapiszListyZadan(List<ListaZadan> listy)
        {
            var tekst = "";

            foreach (var lista in listy)
            {
                tekst += lista.Serializuj();
            }

            File.WriteAllText(GetSciezkaDoPliku(), tekst);
        }

        public static List<ListaZadan> OdczytajListyZadan()
        {
            var listy = new List<ListaZadan>();
            var tekst = "";
            foreach (var linijka in File.ReadLines(GetSciezkaDoPliku()))
            {
                if (linijka.StartsWith("###") && tekst != "")
                {
                    listy.Add(ListaZadan.Deserializuj(tekst));
                    tekst = "";
                }

                tekst += linijka + '\n';
            }

            if (tekst != "")
                listy.Add(ListaZadan.Deserializuj(tekst));

            return listy;
        }

        private static string GetSciezkaDoPliku()
        {
            var sciezka = Path.Combine(Application.CommonAppDataPath, "zadania.txt");
            if (!File.Exists(sciezka)) File.WriteAllText(sciezka, "");
            return sciezka;
        }
    }
}
