using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOAppDesktop.Model
{
    public class ListaZadan
    {
        public string Nazwa { get; set; }
        public List<Zadanie> Zadania { get; } = new List<Zadanie>();

        public ListaZadan(string nazwa)
        {
            Nazwa = nazwa;
        }

        public override string ToString()
        {
            return Nazwa;
        }

        public string Serializuj()
        {
            var wynik = "###" + Nazwa + "\n";
            foreach (var item in Zadania)
            {
                wynik += item.Serializuj() + "\n";
            }

            return wynik;
        }

        public static ListaZadan Deserializuj(string tekst)
        {
            var linijki = tekst.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var lz = new ListaZadan(linijki[0].Substring(3));

            for (int i = 1; i < linijki.Length; i++)
            {
                lz.Zadania.Add(Zadanie.Deserializuj(linijki[i]));
            }

            return lz;
        }
    }
}
