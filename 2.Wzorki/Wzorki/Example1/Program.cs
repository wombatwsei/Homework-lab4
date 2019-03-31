using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();
        public static void Rectangle(int n, int m)
        {
            for (int i = 0; i < n; i++)
                Star();
            NewLine();
            for(int j = 1; j <= m-1; j++)
            {
                Star();
                for (int i = 1; i < n - 1; i++)
                    Space();
                StarLn();
            }
            for (int i = 0; i < n; i++)
                Star();
            NewLine();
        }
        static void letterX(int n)
        {
            if (n < 3) throw new ArgumentException("Size too small");
            if (n % 2 == 0) n += 1;

            for(int i=0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    //if (j == (n / 2) + 1)
                    if (j == i || j == n - 1 - i)
                    {
                        Star();
                    }
                    else
                    {
                        Space();
                    }
                }
                NewLine();
            }
        }
        static void hourglass(int n)
        {
            for (int k = 0; k < n; k++) Star();
            NewLine();
            for (int i = 1; i < n-1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //if (j == (n / 2) + 1)
                    if (j == i || j == n - 1 - i)
                    {
                        Star();
                    }
                    else
                    {
                        Space();
                    }
                }
                NewLine();
            }
            for (int l = 0; l < n; l++) Star();
            NewLine();
        }
        static void chessboard(int n)
        {
            if (n % 2 == 1) n += 1;
            int flag;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) flag = 0;
                else flag = 1;
                for (int j = 0; j < n; j++)
                {
                    if (j % 2 == flag) Star();
                    else Space();
                }
                NewLine();
            }
        }
        static void Main(string[] args)
        {
            Rectangle(10, 11);
            NewLine();
            letterX(11);
            NewLine();
            letterX(16);
            NewLine();
            hourglass(8);
            NewLine();
            hourglass(7);
            NewLine();
            chessboard(8);
            NewLine();
            chessboard(15);
        }
    }
}
