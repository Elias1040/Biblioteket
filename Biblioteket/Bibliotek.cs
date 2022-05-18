using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    class Bibliotek
    {
        string _biblioteksNavn;

        public Bibliotek(string biblioteksNavn)
        {
            _biblioteksNavn = biblioteksNavn;
        }

        public string HentBibliotek()
        {
            return $"Velkommen til {_biblioteksNavn} - datoen idag er: {DateTime.Now}";
        }

        public Laaner OpretLaaner(int laanerNummer, string navn)
        {
            Laaner laaner = new(laanerNummer, navn);
            return laaner;
        }

        public string HentLaaner(int laanerNummer, string navn)
        {
            return $"Lånernummer: {laanerNummer} - Navn: {navn} er låner hos {_biblioteksNavn}";
        }
    }
}
