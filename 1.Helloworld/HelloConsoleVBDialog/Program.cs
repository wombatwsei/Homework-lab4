using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace HelloConsoleVBDialog
{
    class Program
    {
        static void printData(string firstMsg, string titleMsg)
        {
            Interaction.MsgBox(firstMsg, MsgBoxStyle.OkOnly | MsgBoxStyle.Information, titleMsg);
        }
        static string getData(string firstMsg, string titleMsg)
        {
            return Interaction.InputBox(firstMsg, titleMsg);
        }
        static void Main(string[] args)
        {
            const string windowTitle = "Tytul okienka";
            printData("Aplikacja na powitanie!", windowTitle);

            string firstname = getData("Podaj imie", windowTitle);
            string lastname = getData("Podaj nazwisko", windowTitle);

            printData("Witaj " + firstname + " " + lastname, windowTitle);

            int age = Convert.ToInt32(getData("Podaj wiek: ", windowTitle));
            if (age <= 0)
            {
                printData("BLAD KRYTYCZNY", "BLEDNE DANE");
            }
            else if (age > 67)
            {
                printData("Jestes emerytem", windowTitle);
            }
            else if (age <= 19)
            {
                printData("Wracaj do szkoly.", windowTitle);
            }
            else
            {
                printData("Do emerytury zostało Ci " + Convert.ToString(67 - age) + " lat", windowTitle);
            }
        }
    }
}
