using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de su cuota moderadora para citas generales.");
            Console.WriteLine("Inserte su salario: ");
            int sal = int.Parse(Console.ReadLine());
            int a = 3200;
            int b = 12700;
            int c = 33500;
            int salmin = 828116;


            if (sal < 2 * salmin)
            {
                Console.WriteLine("Usted debe pagar la tarifa A: " + a);
            }
            else if (2 * salmin <= sal && sal <= 5 * salmin)
            {
                Console.WriteLine("Usted debe pagar la tarifa B: " + b);
            }
            else
            {
                Console.WriteLine("Usted debe pagar la tarifa c: " + c);
            }
        }
    }
}
