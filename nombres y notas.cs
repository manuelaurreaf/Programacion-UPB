using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {


            int min = 1000;
            int auxiliar = 0;
            string auxiliar2 = "x";

            string[] nombres = { "s", "l", "m", "k", "m" };
            int[] notas = { 1, 2, 1, 5, 4 };

            for (int i = 0; i < notas.Length; i++)
            {

                for (int p = i +1 ; p < notas.Length; p++)
                {
                    if (notas[i] < notas[p])
                    {
                        auxiliar = notas[i];
                        notas[i] = notas[p];
                        notas[p] = auxiliar;

                        auxiliar2 = nombres[i];
                        nombres[i] = nombres[p];
                        nombres[p] = auxiliar2;
                    }
                }
                Console.WriteLine(notas[i] + " " + nombres[i]);
            }
            
            //for (int i = 0; i < notas.Length ; i++)
           // {
                //Console.WriteLine(notas[i] + nombres[i]);
            //}
        }
    }
}
