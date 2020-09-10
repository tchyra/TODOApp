using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOAppDesktop.Model
{
    class Zadanie
    {
        public bool Wykonane { get; set; }
        public string Tresc { get; set; }

        public Zadanie(bool wykonane, string tresc)
        {
            Wykonane = wykonane;
            Tresc = tresc;
        }

        public override string ToString()
        {
            return Tresc;
        }

        public string Serializuj()
        {
            return (Wykonane ? 'x' : '-') + (' ' + Tresc);
        }

        public static Zadanie Deserializuj(string tekst)
        {
            var wykonane = tekst[0] == 'x';
            var tresc = tekst.Substring(2);
            return new Zadanie(wykonane, tresc);
        }
    }
}
