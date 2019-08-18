using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los juegos de azar son del demonio");
            Random aleatorio = new Random();
            int dado1 = 0, total = 0, contador2 = 0, unos = 0, seis = 0, vidas = 3, vidasextra = 0;
            string continuar = "s";

            while (continuar == "s")
            {
                dado1 = aleatorio.Next(1, 7);
                Console.WriteLine("Dado: " + dado1);
                total += dado1;
                Console.WriteLine("Total: " + total);
                contador2 += 1;
                Console.WriteLine("Tiradas: " + contador2);

                if (dado1 ==1)
                {
                    unos += 1;

                    if (unos % 2 == 0)
                    {
                        vidas -= 1;
                        total -= 10;
                        Console.WriteLine("Vidas: " + vidas);
                    }
                   
                    if (vidas <= 0)
                    {
                        Console.WriteLine("Fin del juego");
                        break; 
                    }
                }
                if (vidasextra < 3)
                {
                    if (dado1 == 6) seis += 1;
                    else seis = 0;

                    if (seis == 2 && vidas < 3)
                    {
                        vidas += 1;
                        Console.WriteLine("Vidas: " + vidas);
                        vidasextra += 1;

                    }
                }
                
                Console.Write("Desea continuar? s/n: ");
                continuar = Console.ReadLine();
            }
            Console.WriteLine("Su total fue: " + total);
            Console.WriteLine("Gracias por jugar");
        }
    }
}
