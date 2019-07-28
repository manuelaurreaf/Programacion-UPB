using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de tarifa");
            Console.WriteLine("Inserte su salario: ");
            int sal = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte la tarifa a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte la tarifa b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte la tarifa c: ");
            int c = int.Parse(Console.ReadLine());
            int salmin = 828116;

            if (sal < 2 * salmin)
            {
                Console.WriteLine("Usted debe pagar la tarifa A:$" + a);
            }
            else if ( 2*salmin <= sal && sal <= 4 * salmin)
            {
                Console.WriteLine("Usted debe pagar la tarifa B:$" + b);
            }
            else
            {
                Console.WriteLine("Usted debe pagar la tarifa c:$" + c);
            }


        }
    }
}
