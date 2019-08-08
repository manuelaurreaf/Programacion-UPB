using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a BlackJack");

            Random aleatorio = new Random();
            int carta1 = 0, carta2 = 0, total = 0, carta = 0;
            string respuesta = "s";

            carta1 = aleatorio.Next(1, 11);
            carta2 = aleatorio.Next(1, 11);
            total = carta1 + carta2;
            Console.WriteLine("sus cartas son = " + carta1 + " y " + carta2);
            Console.WriteLine("Su acumulado es = " + total);


            while (respuesta == "s" && total < 21)
            {
                carta  = aleatorio.Next(1, 11);
                Console.WriteLine("Su nueva carta es:  " +carta);
                total += carta;
                Console.WriteLine("Total: " + total);

                if (total < 22)
                { 
                    Console.Write("Deseas continuar (s/n): ");
                    respuesta = Console.ReadLine();
                    
                    Console.WriteLine("Su nueva carta es:  " + carta);
                    total += carta;
                    Console.WriteLine("Total: " + total);

                    if (total == 21) Console.WriteLine("¡Ha ganado!");
                    
                }
                else
                {
                    Console.WriteLine("Eliminado");
                }
                
            }
            Console.WriteLine("Su Total fue: " + total);
            Console.WriteLine("Gracias por jugar.");

        }
    }
}
