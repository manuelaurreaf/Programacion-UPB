using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
          //Datos conocidos
            Console.WriteLine("Para encontrar z, ingrese d, b y y respectivamente: ");
            double d = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double a = 180 -(90 + d + b);
            double ag = a * Math.PI/180;
            double z = y / Math.Tan(ag); 

            Console.WriteLine("z = " + z);
        }
    }
}
