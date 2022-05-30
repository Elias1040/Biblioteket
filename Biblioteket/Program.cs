using Biblioteket;

Bibliotek bibliotek = new Bibliotek(Validation.InputCheckS("Bibliotek:"));
bibliotek.OpretLaaner(1, "Elias", "Elias@gmail.com");
bibliotek.OpretLaaner(2, "Kevin", "Kevin@gmail.com");
bibliotek.OpretLaaner(3, "Lucas", "Lucas@gmail.com");

bool exit = false;
do
{
    Console.Clear();
    Console.WriteLine("Du kan vælge følgende: \nv: Vis bibliotekets navn og dato \no: Opret låner \nu: Udskriv lånere \nf: Find låner \nl: Lån bog \nb: Udskriv bøger \nx: afslut");
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
            string email =  Validation.InputCheckS("Email:");
            Console.WriteLine(bibliotek.OpretLaaner(laanerNummer, navn, email));
            Console.ReadKey();
            break;
        case 'u':
            Console.Clear();
            Console.WriteLine(bibliotek.HentAlleLaanere());
            Console.ReadKey();
            break;
        case 'f':
            Console.Clear();
            Console.WriteLine(bibliotek.FindLaaner(Validation.InputCheckI()));
            Console.ReadKey();
            break;
        case 'l':
            Console.Clear();
            laanerNummer = Validation.InputCheckI();
            string titel = Validation.InputCheckS("Titel:");
            string forfatter = Validation.InputCheckS("Forfatter:");
            string isbn = Validation.InputCheckS("Isbn:");
            Bog bog = new(titel, forfatter, isbn);
            Console.WriteLine(bibliotek.LaanBog(laanerNummer, bog));
            Console.ReadKey();
            break;
        case 'b':
            Console.Clear();
            Console.WriteLine(bibliotek.UdskrivBoeger(Validation.InputCheckI()));
            Console.ReadKey();
            break;
        case 'x':
            exit = true;
            break;
    }
} while (!exit);



