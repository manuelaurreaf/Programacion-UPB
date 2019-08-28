using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a BlackJack");

            Random aleatorio = new Random();
            int jugador = 1, n = 5, total = 0;
            int maximo = 0, max = 0, minimo = 1000;
            int segnombre = 0;
            string nmax = "x";
            string nmin = "x";
            Console.WriteLine("incerte el numero de jugadores (max 5, min 2)");
            int j = int.Parse(Console.ReadLine());
            int[] puntaje = new int[j];
            int[] jugadores = new int[j];
            while (j < 2 || j > 5)
            {
                Console.WriteLine("Error, incerte el numero de jugadores (max 5, min 2)");
                j = int.Parse(Console.ReadLine());
            }
            while (jugador <= j)
            {
                total = 0;
                Console.WriteLine("Bienvenido a BlackJack jugador:" + jugador);
                Console.WriteLine("ingrese su nombre: ");
                string player = (Console.ReadLine());

                int carta1 = 0, carta2 = 0, carta = 0;
                string respuesta = "s";

                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                total = carta1 + carta2;
                Console.WriteLine("sus cartas son = " + carta1 + " y " + carta2);
                Console.WriteLine("Su acumulado es = " + total);
                while (respuesta == "s" && total < 21)
                {
                    carta = aleatorio.Next(1, 11);
                    Console.WriteLine("Su nueva carta es:  " + carta);
                    total += carta;
                    Console.WriteLine("Total: " + total);


                    if (total < 22)
                    {
                        Console.Write("Deseas continuar (s/n): ");
                        respuesta = Console.ReadLine();
                        while (respuesta != "s" && respuesta != "n")
                        {
                            Console.Write("Error,Deseas continuar (s/n): ");
                            respuesta = Console.ReadLine();
                        }
                        // if (Console.ReadLine() != "s") break; 
                        if (total > maximo) maximo = total;
                        if (total == maximo) nmax = player;
                        if (total < minimo) minimo = total;
                        if (total == minimo) nmin = player;

                        if (total == 21) Console.WriteLine("¡Ha ganado!");
                    }
                    else
                    {
                        Console.WriteLine("Eliminado");
                        total = 0;
                        break;
                    }

                }


                puntaje[jugador - 1] = total;
                Console.WriteLine("El puntaje del jugador " + jugador + " es: " + puntaje[jugador - 1]);

                jugador += 1;

                Console.WriteLine("Ganador: " + nmax);
                // Console.WriteLine("Su Total fue: " + total);
                Console.WriteLine("Gracias por jugar.");

            }
            Console.WriteLine("Resultados: ");
            for (int i = 0; i < jugadores.Length; i++)
            {
                
                Console.WriteLine("puntaje del jugador " + (i + 1) + ": " + puntaje[i]);

            }

            for (int i =0; i < jugadores.Length; i++)
            {
                if (minimo < puntaje[i] && puntaje[i] < maximo)
                {
                    Console.WriteLine("El segundo lugar es de: " + (i +1));
                }
            }
            
            Console.ReadKey();

        }
    }
}
