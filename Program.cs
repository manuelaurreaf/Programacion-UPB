using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "A veces un hombre tiene que robar un tejon animatronico para seguir en este juego loco que es la vida".ToUpper();
            Console.WriteLine(entrada);
            Console.WriteLine("Escriba una de las palabras de la frase para buscar: ");
            string palabrabusc = (Console.ReadLine());
            string palabra2 = palabrabusc.ToUpper(); 
            
            for (int i=0; i< entrada.Length - palabra2.Length +1; i++)
            {
                string palabra = "";
                
                for (int j = 0; j < palabra2.Length; j++)
                {
                    palabra += entrada[i + j];
                    
                }
                Console.WriteLine(palabra + "vs" + palabra2);
                if (palabra == palabra2)
                {
                    Console.WriteLine("Palabra" + palabra2 + " encontrada en pos: " + i);
                   
                }
            }
            
        }
    }
}
