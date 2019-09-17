using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "O", "X" };
            int n = 10;
            int m = 15;
            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";
                }
            }
            Console.WriteLine("Entrada: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]); 
                }
                Console.WriteLine("|\n ");
            }
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1)-2; j++)
                {
                    if(tablero[i,j] == tablero[i,j+1] && tablero[i, j] == tablero[i, j+2])
                    {
                        if(tablero[i,j] == "X")
                        {
                            salida[i, j] = "1";
                            salida[i, j+1] = "1";
                            salida[i, j+2] = "1";
                        }
                        if (tablero[i, j] == "O")
                        {
                            salida[i, j] = "2";
                            salida[i, j+1] = "2";
                            salida[i, j+2] = "2";
                        }
                    }
                }
            }
            for (int i = 0; i < tablero.GetLength(0)-2; i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    if (tablero[i, j] == tablero[i+1, j] && tablero[i, j] == tablero[i+2, j])
                    {
                        if (tablero[i, j] == "X")
                        {
                            salida[i, j] = "1";
                            salida[i+1, j] = "1";
                            salida[i+2, j] = "1";
                        }
                        if (tablero[i, j] == "O")
                        {
                            salida[i, j] = "2";
                            salida[i+1, j] = "2";
                            salida[i+2, j] = "2";
                        }
                    }
                }
            }
            Console.WriteLine("Salida: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + salida[i, j]);
                }
                Console.WriteLine("|\n ");
            }
            Console.WriteLine("|\n ");
        }
    }
}
