using BierWinkel;

namespace ConsoleAppBierWinkel
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hellow World");
                Bier b1 = new Bier(1.05, "palm", "amber", "palm", 25, 5.2, 6);
                Inventaris inventaris = new Inventaris();
                inventaris.VoegBierToe(1.05, "palm", "amber", "palm", 25, 5.2, 6);
                inventaris.VoegBierToe(1.25, "rodenbach classic", "bruin", "palm", 25, 5.2, 6);
                inventaris.VoegBierToe(1.6, "leffe bruin", "bruin", "leffe", 33, 6.2, 6);
                inventaris.VoegBierToe(1.8, "duvel", "blond", "duvel moortgat", 33, 8.5, 4);
                Bier x = inventaris.SelecteerBier("palm");
                Console.WriteLine($"Bier:{x}");
                Bier y = inventaris.ZoekBier(b1);
                Console.WriteLine($"Bier:{y}");
            }
        }
    }