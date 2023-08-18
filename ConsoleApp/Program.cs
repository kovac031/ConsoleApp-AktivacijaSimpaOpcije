namespace ConsoleApp
{
    internal class Program
    {
        static void Provjera(double cijenaProvjera)
        {
            Console.WriteLine("Unesi dostupan iznos na racunu:\n");

            string racunUnos = Console.ReadLine();
            double racun = double.Parse(racunUnos);

            Console.WriteLine(cijenaProvjera <= racun ? "\nIznos na racunu je dovoljan i opcija je uspjesno aktivirana!" : "\nIznos na racunu je nedovoljan za aktivaciju.");
        }
        static void DaNe(string opcija, double cijena)
        {            
            Console.WriteLine($"\nAko želite aktivirati opciju {opcija} po cijeni {cijena} EUR, odgovorite s DA. Opcija uključuje blablabla. Odgovori NE za povratak na prijašnji izbornik.\n");

            string odlukaUnos = Console.ReadLine();
            string odluka = odlukaUnos.ToLower();

            switch (odluka)
            {
                case "da":
                    Provjera(cijena);
                    break;

                case "ne":
                    break;

                default:
                    Console.WriteLine("\nNepoznat unos. Pokušajte ponovo.");
                    break;
            }            
        }
        static void Main(string[] args)
        {            
            Console.WriteLine("Na mobitelu ste ušli u izbornik za aktivaciju Simpa opcije.\n");
            
            while (true) // osigurava da se petlja vrati nazad na ovaj korak umjesto da ugasi konzolu
            {
                string[] topIzbornik = { "1. Simpa L", "2. Simpa M", "3. Simpa S", "4. Simpa XS", "5. Simpa Tjedna", "6. Bez Uspostave" };

                Console.WriteLine("Pošaljite broj opcije koju želite aktivirati:\n");
                int i = 0;
                do
                {
                    Console.WriteLine(topIzbornik[i]);
                    i++;
                }
                while (i < topIzbornik.Length);
                string izborOpcije = Console.ReadLine();

                //----------------------- PETLJA -------------------------
                string opcija;
                double cijena;

                switch (izborOpcije)
                {
                    case "1":
                        opcija = "Simpa L";
                        cijena = 14.47;
                        break;

                    case "2":
                        opcija = "Simpa M";
                        cijena = 11.81;
                        break;

                    case "3":
                        opcija = "Simpa S";
                        cijena = 9.16;
                        break;

                    case "4":
                        opcija = "Simpa XS";
                        cijena = 7.83;
                        break;

                    case "5":
                        opcija = "Simpa Tjedna";
                        cijena = 3.19;
                        break;

                    case "6":
                        opcija = "Bez Uspostave";
                        cijena = 1.86;
                        break;

                    default:
                        Console.WriteLine("\nNepoznat unos. Pokušajte ponovo.");
                        continue; // continue preskace daljnji kod, znaci DaNe(opcija, cijena) i posto smo u while(true) - vrati nas na pocetak
                }
                DaNe(opcija, cijena);

                Console.ReadLine();
            }
        }
    }
}