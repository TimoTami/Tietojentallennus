using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennus
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedostoLämpötila = @"C:\Tiedontallennusharjoitus\Lämpötila.txt";
            string tiedostoVanhaLämpötila = @"C:\Tiedontallennusharjoitus\VanhaLämpötila.txt";

            // luetaan tiedostosta aiemmin asetettu lämpötila
            if (File.Exists(tiedostoLämpötila))
            {
                string aiempiArvo = File.ReadAllText(tiedostoLämpötila);
                Console.WriteLine("Aiemmin asetettu lämpötila on " +
                    aiempiArvo + " astetta.");
                File.WriteAllText(tiedostoVanhaLämpötila, aiempiArvo.ToString());
            }
            else
            {
                Console.WriteLine("Tervetuloa!");
            }

            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);

            // tiedostoon kirjoittaminen
            File.WriteAllText(tiedostoLämpötila, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu.");
            Console.WriteLine("Vanha lämpötila oli " + File.ReadAllText(tiedostoVanhaLämpötila) + " astetta.");

            Console.ReadLine();
        }
    }
}
