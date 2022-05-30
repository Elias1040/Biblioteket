using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Bibliotek
    {
        string _biblioteksNavn;
        List<Laaner> _laanere;

        public Bibliotek(string biblioteksNavn)
        {
            _biblioteksNavn = biblioteksNavn;
            _laanere = new();
        }

        public string HentBibliotek()
        {
            return $"Velkommen til {_biblioteksNavn} - datoen idag er: {DateTime.Now.ToShortDateString()}";
        }

        public string OpretLaaner(int laanerNummer, string navn)
        {
            Laaner laaner = new(laanerNummer, navn);
            _laanere.Add(laaner);
            return $"Låner oprettet med id: {laaner._laanerNummer} og navn: {laaner._navn}";
        }

        public string HentLaaner(int laanerNummer, string navn)
        {
            for (int i = 0; i < _laanere.Count; i++)
            {
                if (laanerNummer == _laanere[i]._laanerNummer)
                {
                    return $"Lånernummer: {laanerNummer} - Navn: {navn} er låner hos {_biblioteksNavn}";
                }
            }
            return "Låner eksisterer ikke";
        }

        public string HentAlleLaanere()
        {
            string alleLaanere = string.Empty;
            foreach (Laaner laaner in _laanere)
            {
                alleLaanere += laaner._navn + "\n";
            }
            return alleLaanere;
        }
    }
}
