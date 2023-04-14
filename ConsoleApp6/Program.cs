using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите квадратное уровнение");
            string squEqu = Console.ReadLine();
            string x = "x";
            string equals = "=";
            char notB = '+';
            char notC = '+';

            string a = "";
            int indexA = squEqu.IndexOf(x);
            for (int i = indexA - 1; i > -1; i--)
            {
                a = a.Insert(0, squEqu[i].ToString());
            }
            double aInt = 0;
            if (a == "")
            {
                aInt = 1;
            }
            else if (a == "-")
            {
                aInt = -1;
            }
            else
            {
                aInt = Convert.ToDouble(a);
            }

            string b = "";
            int indexB = squEqu.LastIndexOf(x);
            for (int i = indexB - 1; i > indexA + 2; i--)
            {
                b = b.Insert(0, squEqu[i].ToString());
            }
            double bInt = 0;
            if (b == "")
            {
                bInt = 1;
            }
            else if (b == "-")
            {
                bInt = -1;
            }
            else
            {
                bInt = Convert.ToDouble(b);
            }
                       
            string c = "";
            int indexС = squEqu.LastIndexOf(equals);
            if(squEqu.IndexOf(x) == squEqu.LastIndexOf(x))
            {
                for (int i = indexС - 1; i > indexA + 2; i--)
                {
                    c = c.Insert(0, squEqu[i].ToString());
                }
                notB = '0';
                Console.WriteLine(notB);
                notC = squEqu[indexA + 3];
                Console.WriteLine(notC);
            }
            else
            {
                for (int i = indexС - 1; i > indexB; i--)
                {
                    c = c.Insert(0, squEqu[i].ToString());
                }
                notB = squEqu[indexA + 3];
                Console.WriteLine(notB);
                notC = squEqu[indexB + 1];
                Console.WriteLine(notC);
            }
            double cInt = 0;
            if (c == "")
            {
                cInt = 1;
            }
            else
            {
                cInt = Convert.ToDouble(c);
            }

            double x1 = 0;
            double x2 = 0;

            if ((notB != '+' && notB != '-' ) && (notC == '+' || notC == '-'))
            {
                Console.WriteLine("a = " + aInt);
                Console.WriteLine("c = " + cInt);
                if ((aInt / cInt) < 0)
                {
                    Console.WriteLine("Нет корней");
                }
                else
                {
                    x1 = Math.Sqrt(-aInt / -cInt);
                    Console.WriteLine("x = " + x1);
                }
            }
            else if ((notC != '+' && notC != '-') && (notB == '+' || notB == '-'))
            {
                Console.WriteLine("a = " + aInt);
                Console.WriteLine("b = " + bInt);
                x1 = 0;
                x2 = -bInt / -aInt;
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (notB != '+' && notB != '-' && notC != '+' && notC != '-')
            {
                Console.WriteLine("a = " + aInt);
                if (aInt < 0)
                {
                    Console.WriteLine("Нет корней");
                }
                else
                {
                    x1 = Math.Sqrt(-aInt);
                    Console.WriteLine("x1 = " + x1);
                }
            }
            else if ((notB == '+' || notB == '-') && (notC == '+' || notC == '-')) 
            {
                Console.WriteLine("a = " + aInt);
                Console.WriteLine("b = " + bInt);
                Console.WriteLine("c = " + cInt);
                double D = Math.Pow(bInt, 2) - 4 * aInt * cInt;
                Console.WriteLine("D = " + D);
                if(D < 0)
                {
                    Console.WriteLine("Нет корней");
                }
                else if (D == 0)
                {
                    x1 = -bInt / (2 * aInt);
                    Console.WriteLine("x = " + x1);
                }
                else
                {
                x1 = (-bInt + Math.Sqrt(D)) / (2 * aInt);
                Console.WriteLine("x1 = " + x1);

                x2 = (-bInt - Math.Sqrt(D)) / (2 * aInt);
                Console.WriteLine("x2 = " + x2);
                }
            }

            Console.ReadLine();
        }
    }
}