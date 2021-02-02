using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número (Inteiro): ");
            Int32 i1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o exponencial: ");
            Int32 i2 = Convert.ToInt32(Console.ReadLine());
            Double r = Math.Pow(i1, i2);
            Console.WriteLine("O resultado é: " + r);
            Console.ReadKey();
        }
    }
}
