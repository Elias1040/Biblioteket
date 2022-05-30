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
        List<Bog> _boeger;
        public int LaanerNummer { get { return _laanerNummer;} }
        public List<Bog> Boeger { get { return _boeger; } }

        public Laaner(int laanerNummer, string navn, string email)
        {
            _laanerNummer = laanerNummer;
            _navn = navn;
            _email = email;
            _boeger = new();
        }
    }
}
