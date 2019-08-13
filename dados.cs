using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1muf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los juegos de azar son del demonio");
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = 0, contador1 = 0, contador2 = 0, m6 = 0;
            string continuar = "s";

            while (continuar == "s" )
            {
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);
                Console.WriteLine("Dado 1: " + dado1);
                Console.WriteLine("Dado 2: " + dado2);
                contador2 += 1;
                Console.WriteLine("Tiradas: "+ contador2);

                if (dado1 == 1 && dado2 == 1)
                {
                    total = 0;
                    Console.WriteLine("Perdites Wey");
                    break;
                }
                else
                {
                    total += dado1 + dado2;
                    Console.WriteLine("Total = " + total);
                    if ((dado1 + dado2) > 6)
                    {
                        m6 += 1;
                    }

                    if (dado1 == dado2)
                    {
                        contador1 += 1;
                        Console.WriteLine("Contador: " + contador1);
                        if (contador1 == 3)
                        {
                            Console.WriteLine("Ganates Wey");
                            break; 
                        }
                    }
                    if (total>= 100)
                    {
                        break;
                    }
                    Console.Write("Desea continuar? s/n: ");
                    continuar = Console.ReadLine();


                }

            }
            int porcentaje = (m6 * 100) / contador2;
            Console.WriteLine("El porcentaje de veces que saco mas de 6 es: " + porcentaje + "%");
            Console.WriteLine("Su total fue: " + total);
            Console.WriteLine("Gracias por jugar");
            


        }
    }
}
