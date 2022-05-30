using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Laaner : Person
    {
        int _laanerNummer;
        public int LaanerNummer { get { return _laanerNummer;} }

        public Laaner(int laanerNummer, string navn, string email)
        {
            _laanerNummer = laanerNummer;
            _navn = navn;
            _email = email;
        }
    }
}
