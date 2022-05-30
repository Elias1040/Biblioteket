using Biblioteket;

Console.WriteLine("Bibliotek:");
Bibliotek bibliotek = new Bibliotek(Console.ReadLine());
Console.WriteLine(bibliotek.HentBibliotek());
List<Laaner> list = new List<Laaner>();
list.Add(new(0, "Elias"));
list.Add(new(1, "Kevin"));
list.Add(new(2, "Lucas"));

bool _failed = false;
do
{
    try
    {
        Console.WriteLine("Lånenummer:");
        int _laanerNummer;
        int.TryParse(Console.ReadLine(), out _laanerNummer);
        Console.WriteLine("Navn:");
        string _navn = Console.ReadLine();
        Console.WriteLine(bibliotek.OpretLaaner(_laanerNummer, _navn));
    }
    catch (NullReferenceException)
    {
        Console.WriteLine("Prøv igen");
        _failed = true;
    }
} while (_failed);
try
{
    Console.WriteLine("Lånenummer:");
    int _laanerNummer;
    int.TryParse(Console.ReadLine(), out _laanerNummer);
    Console.WriteLine("Navn:");
    string _navn = Console.ReadLine();
    Console.WriteLine(bibliotek.HentLaaner(_laanerNummer, "a"));
}
catch (NullReferenceException)
{
    Console.WriteLine("Låner eksistrere ikke");
}

