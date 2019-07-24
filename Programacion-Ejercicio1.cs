using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos conocidos 
            Console.WriteLine("Para encontrar x, ingrese b, z y y respectivamente: ");
            double b = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //Operaciones
            double a = Math.Atan(y / z);
            double ag = a * 180 / Math.PI;
            double x = z * Math.Tan((b + ag) * Math.PI/180) -y;

            //fin
            Console.WriteLine("x = " + x);
            Console.WriteLine("a = " + ag);
            
        }
    }
}
