using Xunit;
using Biblioteket;
using System;

namespace UnitTest_Biblioteket
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("")]
        [InlineData("a")]
        public void Test1(string biblioteksnavn)
        {
            Bibliotek bibliotek = new Bibliotek(biblioteksnavn);
            Assert.Equal($"Velkommen til a - datoen idag er: {DateTime.Now.ToShortDateString()}", bibliotek.HentBibliotek());
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(0, "")]
        [InlineData(0, "a")]
        public void Test2(int laanerNummer, string navn)
        {
            Bibliotek bibliotek = new Bibliotek("a");
            Laaner laaner = new(0, "a");
            Assert.Equal(laaner.Navn, bibliotek.OpretLaaner(laanerNummer, navn).Navn);
            Assert.Equal(laaner.LaanerNummer, bibliotek.OpretLaaner(laanerNummer, navn).LaanerNummer);
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(0, "")]
        [InlineData(0, "a")]
        public void Test3(int laanerNummer, string navn)
        {
            Bibliotek bibliotek = new Bibliotek("a");
            Laaner laaner = new(0, "a");
            Assert.Equal("Lånernummer: 0 - Navn: a er låner hos a", bibliotek.HentLaaner(laanerNummer, navn));
        }
    }
}