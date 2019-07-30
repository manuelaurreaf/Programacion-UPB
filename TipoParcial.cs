using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de deducciones salariales.");
            Console.WriteLine("Ingrese su salrio actual: ");
            int sal = int.Parse(Console.ReadLine());
            int salmin = 828116;
            double arl = 0;
            double bc = sal * 0.40;
            double pen = bc * 0.16;
            double eps = bc * 0.125;
            double bon = sal;

            

            Console.WriteLine("Si su contrato es dependiente, ingrese D");
            Console.WriteLine("Si su contrato es independiente, ingrese I");
            string Cont = Console.ReadLine();

            if (Cont == "I")
            {
                if ( bc < salmin)
                {
                    bc = salmin;
                    Console.WriteLine("Ingrese de 1 a 5, el equivalente a la clase de riesgo de su trabajo: ");
                    int riesgo = int.Parse(Console.ReadLine());
                    double r1 = 0.522 / 100;
                    double r2 = 1.044 / 100;
                    double r3 = 2.436 / 100;
                    double r4 = 4.350 / 100;
                    double r5 = 6.960 / 100;

                    if (riesgo == 1)
                    {
                        arl = r1 * bc;
                    }
                    else if (riesgo == 2)
                    {
                        arl = r2 * bc;
                    }
                    else if (riesgo == 3)
                    {
                        arl = r3 * bc;
                    }
                    else if (riesgo == 4)
                    {
                        arl = r4 * bc;
                    }
                    else
                    {
                        arl = r5 * bc;
                    }
                    pen = bc * 0.16;
                    eps = bc * 0.125;
                }
                else
                {
                    Console.WriteLine("Ingrese de 1 a 5, el equivalente a la clase de riesgo de su trabajo: ");
                    int riesgo = int.Parse(Console.ReadLine());
                    double r1 = 0.522 / 100;
                    double r2 = 1.044 / 100;
                    double r3 = 2.436 / 100;
                    double r4 = 4.350 / 100;
                    double r5 = 6.960 / 100;

                    if (riesgo == 1)
                    {
                        arl = r1 * bc;
                    }
                    else if (riesgo == 2)
                    {
                        arl = r2 * bc;
                    }
                    else if (riesgo == 3)
                    {
                        arl = r3 * bc;
                    }
                    else if (riesgo == 4)
                    {
                        arl = r4 * bc;
                    }
                    else
                    {
                        arl = r5 * bc;
                    }
                    pen = bc * 0.16;
                    eps = bc * 0.125;
                }
                double salreal = sal - arl - pen - eps;
                Console.WriteLine("las deudaciones que recibira son: ");
                Console.WriteLine("Arl: " + arl);
                Console.WriteLine("Eps: " + eps);
                Console.WriteLine("Pen: " + pen);
                Console.WriteLine("Salario real: " + salreal);
                Console.WriteLine("Salario anual: " +(salreal*12) +bon );
            }
            else
            {
                pen = bc * 0.04;
                eps = bc * 0.04;
                double salreal = sal - arl - pen - eps;
                Console.WriteLine("las deudaciones que recibira son: ");
                Console.WriteLine("Arl: " + arl);
                Console.WriteLine("Eps: " + eps);
                Console.WriteLine("Pen: " + pen);
                Console.WriteLine("Salario real: " + salreal);
                Console.WriteLine("Salario anual: " + (salreal * 12) + bon);

            }
        }
    }
}
