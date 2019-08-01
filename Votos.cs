using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nVotos: ");

            Console.WriteLine("Numero de votos por el partido 1:  ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de votos por el partido 2:  ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de votos en blanco:  ");
            int blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de votos anulados:  ");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero total de la población:  ");
            int poblacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentaje de la población, de 1 a 100, que son mayores de edad: ");
            int p = int.Parse(Console.ReadLine());

            int nv = a + b + blanco + anulados;
            int abstencion = ((poblacion * p) / 100) - nv;
            int poblacionmayor = (poblacion * p) / 100;
            Console.WriteLine("Numero total de la población mayor de edad:  " + poblacionmayor);
            Console.WriteLine("Numero total de votantes:  " + nv);
            Console.WriteLine("abstencion:  " + abstencion);


            bool x = anulados < (a + b) * 30 / 100;
            bool y = (a + b) > blanco;
            bool z = abstencion < nv;
            bool i = a < b;
            bool d = b < a;






            if ((x || y) && z)
            {
                Console.WriteLine("\n¡Las votaciones fueron exitosas!, si voto, ha ganado un descuento en Corral");
                if (i) Console.WriteLine("Gano el partido 2");
                else Console.WriteLine("Gano el partido 1");
            }

            else Console.WriteLine("\nLas votaciones se tienen que hacer otra vez :,(");


        }
    }
}
