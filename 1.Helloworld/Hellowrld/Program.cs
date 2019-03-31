using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellowrld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj imie: ");
            string firstname = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Witaj {0} {1}.", firstname, lastname);
            Console.Write("Podaj wiek: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age > 67)
            {
                Console.WriteLine("Jesteś emerytem.");

            }
            else if(age <= 19)
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
