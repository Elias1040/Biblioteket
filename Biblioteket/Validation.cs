using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public static class Validation
    {
        // Bruger TryParse til validere værdier
        public static int InputCheckI()
        {
            int laanerNummer;
            Console.WriteLine("Lånernummer:");
            while (!int.TryParse(Console.ReadLine(), out laanerNummer))
            {
                Console.Clear();
                Console.WriteLine("Ugyldig indtastning");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Lånernummer:");
            }
            Console.Clear();
            return laanerNummer;
        }

        // Validere om det er en tom string
        public static string InputCheckS(string type)
        {
            string value = string.Empty;
            while (value == string.Empty)
            {
                Console.WriteLine(type);
                value = Console.ReadLine();
                if (value == string.Empty)
                {
                    Console.Clear();
                    Console.WriteLine("Felt påkrævet");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            return value;
        }
    }
}
