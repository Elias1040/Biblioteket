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

        public string OpretLaaner(int laanerNummer, string navn, string email)
        {
            Laaner laaner = new(laanerNummer, navn, email);
            _laanere.Add(laaner);
            return $"Låner oprettet med id: {laaner.LaanerNummer}, navn: {laaner.Navn} og email: {laaner.Email}";
        }

        // Henter laaner ud fra laaneNummer, navn og email
        public string HentLaaner(int laanerNummer, string navn, string email)
        {
            foreach (Laaner laaner in _laanere)
            {
                if (laanerNummer == laaner.LaanerNummer && navn == laaner.Navn && email == laaner.Email)
                {
                    return $"Lånernummer: {laaner.LaanerNummer} - Email: {laaner.Email} - Navn: {laaner.Navn} er låner hos {_biblioteksNavn}";
                }
            }
            return "Låner eksisterer ikke";
        }

        // Finder laaner ud fra lånernummeret
        public string FindLaaner(int laanerNummer)
        {
            foreach (Laaner laaner in _laanere)
            {
                if (laanerNummer == laaner.LaanerNummer)
                {
                    return $"Lånernummer: {laaner.LaanerNummer} - Navn: {laaner.Navn} - Email: {laaner.Email}";
                }
            }
            return "Låner eksisterer ikke";
        }

        public string HentAlleLaanere()
        {
            string alleLaanere = string.Empty;
            foreach (Laaner laaner in _laanere)
            {
                alleLaanere += laaner.Navn + "\n";
            }
            return alleLaanere;
        }

        // Tilføjer et bog objekt til laaners bogliste 
        public string LaanBog(int laanerNummer, Bog bog)
        {
            for (int i = 0; i < _laanere.Count; i++)
            {
                if (laanerNummer == _laanere[i].LaanerNummer)
                {
                    _laanere[i].Boeger.Add(bog);
                }
            }
            return $"Titel: {bog.Titel} er lånt - {bog.Udlaansdato.ToShortDateString()}";
        }

        // Udskriver alle lånte bøger ud fra lannerNummer
        public string UdskrivBoeger(int laanerNummer)
        {
            string boeger = string.Empty;
            foreach (Laaner laaner in _laanere)
            {
                if (laanerNummer == laaner.LaanerNummer)
                {
                    foreach (Bog bog in laaner.Boeger)
                    {
                        boeger += $"Titel\tForfatter\tUdlånsdato\n{bog.Titel}\t{bog.Forfatter}\t{bog.Udlaansdato.ToShortDateString()}\n";
                    }
                }
            }
            if (boeger == string.Empty)
                return "Der er ingen lånte bøger";
            else
                return boeger;
        }
    }
}
