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

        private static string GetSciezkaDoPliku()
        {
            var sciezka = Path.Combine(Application.CommonAppDataPath, "zadania.txt");
            if (!File.Exists(sciezka)) File.WriteAllText(sciezka, "");
            return sciezka;
        }
    }
}
