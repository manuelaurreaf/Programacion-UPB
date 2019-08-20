using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Captcha");
            

            Random aleatorio = new Random();
            int a = aleatorio.Next(1, 10);
            Console.WriteLine("a= " + a);
            int b = aleatorio.Next(1, 10);
            Console.WriteLine("b= " + b);
            int sumacorrecta = a + b;
            int intentos = 0;
            Console.WriteLine("Ingrese el resultado de la suma:");
            int r = int.Parse(Console.ReadLine());

            while (sumacorrecta != r)
            {
                Console.WriteLine("Error");
                intentos += 1;
                if (intentos < 3)
                {
                    a = aleatorio.Next(1, 10);
                    Console.WriteLine("a= " + a);
                    b = aleatorio.Next(1, 10);
                    Console.WriteLine("b= " + b);
                    sumacorrecta = a + b;
                    Console.WriteLine("Ingrese el resultado de la suma:");
                    r = int.Parse(Console.ReadLine());
                }
               
                else 
                {
                    Console.WriteLine("Cuenta bloqueada");
                    break;
                }
   
            }

            if (intentos < 3) Console.WriteLine("comienza el programa");
        }
    }
}
