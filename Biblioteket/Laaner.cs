using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Laaner
    {
        public int _laanerNummer;
        public string _navn;

        public Laaner(int laanerNummer, string navn)
        {
            _laanerNummer = laanerNummer;
            _navn = navn;
        }
    }
}
