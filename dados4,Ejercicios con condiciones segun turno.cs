using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Los juegos de azar son del demonio");
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = 0, contador2 = 0, unos = 0, seis = 0, vidas = 3, vidasextra = 0;
            string continuar = "s";

            while (continuar == "s")
            {
                dado1 = aleatorio.Next(1, 4);
                Console.WriteLine("Dado: " + dado1);
                total += dado1;
                Console.WriteLine("Total: " + total);
                contador2 += 1;
                Console.WriteLine("Tiradas: " + contador2);

                    if (contador2 % 3 == 0)
                    {
                        vidas -= 1;
                        Console.WriteLine("Vidas: " + vidas);
                       
                    }
                    if (contador2 %4 == 0)
                    {
                        dado2 = aleatorio.Next(1, 4);
                        Console.WriteLine("Dado2: " + dado2);
                        if (dado1 == dado2)
                        {
                            vidas += 1;
                            Console.WriteLine("Vidas: " + vidas);
                        }
                    }
                
                    if (vidas <= 0)
                    {
                        Console.WriteLine("Fin del juego");
                        break;
                    }
                
                Console.Write("Desea continuar? s/n: ");
                continuar = Console.ReadLine();
            }
            Console.WriteLine("Su total fue: " + total);
            Console.WriteLine("Gracias por jugar");
        }
    }
}
