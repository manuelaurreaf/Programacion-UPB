using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de edades a evaluar: ");
            int datos = int.Parse(Console.ReadLine());
            double total = 0;
            int contador = 0;
            int maximo = 0;
            int minimo = 100;
            string nmax = "x";
            string nmin = "y";

            while (contador < datos)
            {
                Console.Write("Ingrese su nombre: ");
                string nombre = (Console.ReadLine());
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());


                if (edad > maximo) {
                    maximo = edad;

                }

                if (edad < minimo) {
                    minimo = edad;
                }

                if (edad == maximo) nmax = nombre;
                if (edad == minimo) nmin = nombre;

                total += edad;
                contador += 1;
            }
            double promedio = total / contador;
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Mayor: " + nmax);
            Console.WriteLine("Menor: " + nmin);


        }
    }
}
