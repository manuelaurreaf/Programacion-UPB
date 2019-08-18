using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los juegos de azar son del demonio");
            Random aleatorio = new Random();
            int dado1 = 0, total = 0, contador2 = 0, contador12 = 0, contador10 = 0; 
            string continuar = "s";


            while (continuar == "s")
            {
                dado1 = aleatorio.Next(1, 13);
                Console.WriteLine("Dado 1: " + dado1);
                contador2 += 1;
                Console.WriteLine("Tiradas: " + contador2);

                if (contador2 <= 3)
                {
                    total += dado1;
                    Console.WriteLine("Total = " + total);
                    Console.Write("Desea continuar? s/n: ");
                    continuar = Console.ReadLine();
                }
                else if (dado1 % 2 == 0)
                {
                    //el numero es par
                    total += dado1;
                    Console.WriteLine("Total = " + total);

                    if (dado1 == 12)
                    {
                        contador12 = 1;

                    }
                    if (contador12 == 1)
                    {
                        if (dado1 == 10) contador10 = 1;
                        else contador10 = 0; 
                    }
                    if (contador12 + contador10 == 2)
                    {
                       Console.WriteLine("Ganaste");
                       break;
                    }
                    
                    if (total >= 100)
                    {
                        break;
                    }
                    Console.Write("Desea continuar? s/n: ");
                    continuar = Console.ReadLine();
                }
                else
                {
                    //el numero es inpar
                    total = 0;
                    Console.WriteLine("Perdiste");
                    break;
                }
            }
            
            Console.WriteLine("Gracias por jugar");
        }
    }
}
