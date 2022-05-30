using Biblioteket;

Bibliotek bibliotek = new Bibliotek(Validation.InputCheckS("Bibliotek:"));
bibliotek.OpretLaaner(1, "Elias");
bibliotek.OpretLaaner(2, "Kevin");
bibliotek.OpretLaaner(3, "Lucas");

bool exit = false;
do
{
    Console.Clear();
    Console.WriteLine("Du kan vælge følgende: \nv: Vis bibliotekets navn og dato \no: Opret låner \nu: Udskriv lånere \nx: afslut");
    switch (Console.ReadKey().KeyChar)
    {
        case 'v':
            Console.Clear();
            Console.WriteLine(bibliotek.HentBibliotek());
            Console.ReadKey();
            break;
        case 'o':
            Console.Clear();
            int laanerNummer = Validation.InputCheckI();
            string navn =  Validation.InputCheckS("Navn:");
            Console.WriteLine(bibliotek.OpretLaaner(laanerNummer, navn));
            Console.ReadKey();
            break;
        case 'u':
            Console.Clear();
            Console.WriteLine(bibliotek.HentAlleLaanere());
            Console.ReadKey();
            break;
        case 'x':
            exit = true;
            break;
    }
} while (!exit);



