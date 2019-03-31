using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleAppBatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastname;
            int age;

            if (args.Length >= 1)
            {
                firstname = args[0];
            } else {
                Console.Write("Podaj imie: ");
                firstname = Console.ReadLine();
            }

            if (args.Length >= 2)
            {
                lastname = args[1];
            } else {
                Console.Write("Podaj nazwisko: ");
                lastname = Console.ReadLine();
            }

            Console.WriteLine("Witaj {0} {1}.", firstname, lastname);
            if (args.Length >= 3)
            {
                age = 0;
                try
                {
                    age = Convert.ToInt32(args[2]);
                }
                catch
                {
                    Console.WriteLine("Bledna liczba!");
                }
            }
            else
            {
                Console.Write("Podaj wiek: ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            if (age <= 0)
            {
                Console.WriteLine("BLAD KRYTYCZNY, BLEDNA LICZBA!");
            }
            else
            {
                Console.Write("Masz {0} lat: ", age);

                if (age > 67)
                {
                    Console.WriteLine("Jesteś emerytem.");
                }
                else if (age <= 19)
                {
                    Console.WriteLine("Wracaj do szkoly.");
                }
                else
                {
                    Console.WriteLine("Do emerytury zostało Ci {0} lat", 67 - age);
                }
            }
        }
    }
}
