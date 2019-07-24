using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos conocidos
            Console.WriteLine("Para encontrar y, ingrese w, d y x respectivamente: ");
            double w = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double z = w * Math.Sin(d * Math.PI/180);
            double y = (z / Math.Tan(d * Math.PI / 180)) - x;

            
            Console.WriteLine("y = " + y);
        }
    }
}
