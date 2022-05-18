using Biblioteket;

Bibliotek bibliotek = new Bibliotek(Console.ReadLine());
Console.WriteLine(bibliotek.HentBibliotek());
Laaner laaner = bibliotek.OpretLaaner(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
Console.WriteLine(bibliotek.HentLaaner(laaner.LaanerNummer, laaner.Navn));