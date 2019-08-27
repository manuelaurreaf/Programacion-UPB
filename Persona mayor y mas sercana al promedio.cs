using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Igrese el numero de datos que se tiene:");
            int n = int.Parse(Console.ReadLine());
            
            string[] nombre = new string[n];
            int[] edad = new int[n];
            int max = 0;
            int min = 200;
            string name = "0";
            string name2 = "0";
            string name3 = "0";
            double total = 0;
            double d = 0;
            double sumatoria = 0;
            double dmin = 1000;

            for(int i=0; i < edad.Length; i++)
            {
                Console.WriteLine("Igrese el nombre: ");
                nombre[i] =(Console.ReadLine());
                Console.WriteLine("Igrese la edad: ");
                edad[i] = int.Parse(Console.ReadLine());

                total += edad[i];
                Console.WriteLine("Suma de las edades: " + total);
                if (edad[i] > max)
                {
                    max = edad[i];
                    name = nombre[i];
                }
                if (edad[i] < min)
                {
                    min = edad[i];
                    name2 = nombre[i];
                }

            }
            double promedio = total / edad.Length;
            for (int i = 0; i < edad.Length; i++)
            {
                int xi = edad[i];
                sumatoria += Math.Pow((xi - promedio), 2);
                double d0 = Math.Pow((edad[i] - promedio) , 2);

                if (d0 < dmin)
                {
                    dmin = d0;
                    name3 = nombre[i];
                }
            }

            d = Math.Sqrt(sumatoria / n);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Desviación estándar: " + d);
            Console.WriteLine("La perona con la edad mas cercana a la media es: " + name3);
            Console.WriteLine("El mayor es "+ name + " con una edad de:"+ max + " años");
            Console.WriteLine("El menor es " + name2 + " con una edad de:" + min + " años");
        }
    }
}
