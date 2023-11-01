using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            double a, b,c,akat,bkat,ckat;
            Console.WriteLine("A'yı gir. ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Sayı gir.");
            }

            Console.WriteLine("A kat gir. ");
            while (!double.TryParse(Console.ReadLine(), out akat))
            {
                Console.WriteLine("Sayı gir.");
            }

            Console.WriteLine("B'yi gir. ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Sayı gir.");
            }

            Console.WriteLine("B kat gir. ");
            while (!double.TryParse(Console.ReadLine(), out bkat))
            {
                Console.WriteLine("Sayı gir.");
            }

            Console.WriteLine("C'yi gir. ");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Sayı gir.");
            }

            Console.WriteLine("C kat gir. ");
            while (!double.TryParse(Console.ReadLine(), out ckat))
            {
                Console.WriteLine("Sayı gir.");
            }

            Console.WriteLine("operatör gir: ");
            string operator1 = Console.ReadLine();

            Console.WriteLine("2.operatör gir: ");
            string operator2= Console.ReadLine();




            double sonuc = CozDenklem(akat, a, bkat, b,ckat,c, operator1, operator2);
            Console.WriteLine("Sonuc:" + sonuc);
        }

        static double CozDenklem(double aKatsayi, double aDeger, double bKatsayi, double bDeger, double cKatsayi, double cDeger, string operator1, string operator2 )
        {

            double sonuc = 0;

            switch (operator1)
            {
                case "+": sonuc= (aKatsayi * aDeger) + (bKatsayi * bDeger);
                    if (operator2 == "+") sonuc = (aKatsayi * aDeger) + (bKatsayi * bDeger) + (cKatsayi * cDeger);
                    else if (operator2 == "-") sonuc = (aKatsayi * aDeger) + (bKatsayi * bDeger) - (cKatsayi * cDeger);
                    else if (operator2 == "*") sonuc= (aKatsayi * aDeger) + (bKatsayi * bDeger) * (cKatsayi * cDeger);
                    else if (operator2 == "/") sonuc = (aKatsayi * aDeger) + (bKatsayi * bDeger) / (cKatsayi * cDeger);
                    else Console.WriteLine(" +, -, *, / operatörlerinden birini girmediniz!");
                    break;
                  
            }
            return sonuc;

            //return (aKatsayi * aDeger) + (bKatsayi * bDeger) - (cKatsayi * cDeger);
        }

    } 
}


