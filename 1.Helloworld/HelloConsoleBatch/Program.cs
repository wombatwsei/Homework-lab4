using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleBatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = args[0];
            string lastname = args[1];
            Console.WriteLine("Witaj {0} {1}.", firstname, lastname);
            int age = Convert.ToInt32(args[2]);
            Console.Write("Masz {0} lat: ",age);
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
