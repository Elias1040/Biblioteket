using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    class Bibliotek
    {
        string biblioteksNavn;

        public Bibliotek(string navn)
        {
            this.biblioteksNavn = navn;
        }

        public string HentBibliotek()
        {
            return $"Velkommen til {biblioteksNavn} datoen idag er: {DateTime.Now}";
        }
    }
}
