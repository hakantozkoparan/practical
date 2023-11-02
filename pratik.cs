using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

            Console.WriteLine("denklem girin.");
            string denklem = Console.ReadLine();

            Dictionary<char, int> values = new Dictionary<char, int>();

            foreach (char c in denklem)
            {
                if (char.IsLetter(c))
                {
                    if (!values.ContainsKey(c))
                    {
                        Console.WriteLine($"Lütfen '{c}' için bir değer girin:");
                        values.Add(c, Convert.ToInt32(Console.ReadLine()));
                    }
                }
            }

            int sonuc = SolveEquation(denklem, values);
            Console.WriteLine($"Denklemin sonucu: {sonuc}");

            static int SolveEquation(string equation, Dictionary<char, int> values)
            {
                string replacedEquation = equation;

                foreach (var pair in values)
                {
                    replacedEquation = replacedEquation.Replace(pair.Key.ToString(),"*" + pair.Value.ToString()); // anahtar ve değer * olmazsa AA yazıldığında a = 2 ise 22 olarak çıkar.
                }

                DataTable dt = new DataTable();
                object result = dt.Compute(replacedEquation, "");

                return Convert.ToInt32(result);
            }
    }
    } 
}


