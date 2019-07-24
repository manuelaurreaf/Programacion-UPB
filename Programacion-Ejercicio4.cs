using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos
            Console.WriteLine("Para encontrar x, ingrese w, t y c respectivamente: ");
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double z = t * Math.Sin(c * Math.PI / 180);
            double y = t * Math.Cos(c * Math.PI / 180);
            double s = Math.Sqrt(w * w - z * z);
            double x = s - y;

            
            Console.WriteLine("x =" + x);
        }
    }
}
