using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa cinco numeros entre 1 y 0");

            Console.Write("ingrese b4: ");
            int b4 = int.Parse(Console.ReadLine());
            Console.Write("ingrese b3: ");
            int b3 = int.Parse(Console.ReadLine());
            Console.Write("ingrese b2: ");
            int b2 = int.Parse(Console.ReadLine());
            Console.Write("ingrese b1: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese b0: ");
            int b0 = int.Parse(Console.ReadLine());

            double r = b4 * (Math.Pow(2, 4)) + b3 * (Math.Pow(2, 3)) + b2 * (Math.Pow(2, 2)) + b1 * (Math.Pow(2, 1)) + b0 * (Math.Pow(2, 0));

            Console.WriteLine("r =" + r);

        }
    }
}
