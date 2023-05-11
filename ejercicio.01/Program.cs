using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int suma;
            Console.Write("ingresar el primer numero");
            numero1 = int.Parse( Console.ReadLine());
            Console.Write("ingresar el segundo numero");
            numero2 = int.Parse( Console.ReadLine());
            suma = numero1 + numero2;

            Console.Write($"la suma es { suma}");

        }
    }
}
