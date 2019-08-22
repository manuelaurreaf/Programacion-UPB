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
            double[] coordsX = { 0, 2, 3, 7 };
            double[] coordsY = { 0, 1, 5, 6 };


            double m0 = (coordsY[1] - coordsY[0]) / (coordsX[1] - coordsX[0]);
            double b0 = coordsY[0] - (m0 * coordsX[0]);
            double d0 = Math.Sqrt(Math.Pow((coordsY[1] - coordsY[0]), 2) + Math.Pow((coordsX[1] - coordsX[0]), 2));

            double m1 = (coordsY[2] - coordsY[1]) / (coordsX[2] - coordsX[1]);
            double b1 = coordsY[1] - (m0 * coordsX[1]);
            double d1 = Math.Sqrt(Math.Pow((coordsY[2] - coordsY[1]), 2) + Math.Pow((coordsX[2] - coordsX[1]), 2));

            double m2 = (coordsY[3] - coordsY[2]) / (coordsX[3] - coordsX[2]);
            double b2 = coordsY[2] - (m0 * coordsX[2]);
            double d2 = Math.Sqrt(Math.Pow((coordsY[3] - coordsY[2]), 2) + Math.Pow((coordsX[3] - coordsX[2]), 2));


            if (m0 == m1 && b0 == b1)
            {
                if (m1 == m2 && b1 == b2)
                {
                    Console.WriteLine("Pertenecen a la misma línea recta");
                }

               
                if (d0 == d1 && d1 == d2) Console.WriteLine("Tienen la misma distanncia" + d0);
            }
            else
            {
                Console.WriteLine("No es la misma recta");
            }

            if (d0<d1 && d1>d2) Console.WriteLine("la distancia mayor es:" + d1);
            else if (d1<d0 && d0>d2) Console.WriteLine("la distancia mayor es:" + d0);
            else Console.WriteLine("la distancia mayor es:" + d2); 
        }   
    }
}
