using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deducciones_salariales
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
            
            if ((sal * 0.4) >= salmin)
            {
                bc = sal * 0.4;
            }
            else
            {
                bc = salmin;
            }

            Console.WriteLine("Si su contrato es dependiente, ingrese D");
            Console.WriteLine("Si su contrato es independiente, ingrese I");
            string Cont = Console.ReadLine();
            


            switch (Cont)
            {
                case "I":
                
                    Console.WriteLine("Ingrese de 1 a 5, el equivalente a la clase de riesgo de su trabajo: ");
                    int riesgo = int.Parse(Console.ReadLine());
                    double r1 = 0.522 / 100;
                    double r2 = 1.044 / 100;
                    double r3 = 2.436 / 100;
                    double r4 = 4.350 / 100;
                    double r5 = 6.960 / 100;

                    switch (riesgo)
                    {
                        case 1:
                            arl = r1 * bc;
                            break;
                        case 2:
                            arl = r2 * bc;
                            break;
                        case 3:
                            arl = r3 * bc;
                            break;
                        case 4:
                            arl = r4 * bc;
                            break;
                        case 5:
                            arl = r5 * bc;
                            break;
                        default:
                            Console.WriteLine("Hay un error con el número ingresado");
                            break;
                    }
                    
                    pen = bc * 0.16;
                    eps = bc * 0.125;
                    double salreal = sal - (arl + pen + eps);
                    Console.WriteLine("las deudaciones que recibira son: ");
                    Console.WriteLine("Arl: " + arl);
                    Console.WriteLine("Eps: " + eps);
                    Console.WriteLine("Pen: " + pen);
                    Console.WriteLine("Salario real: " + salreal);
                    Console.WriteLine("Salario anual: " + (salreal * 12) + bon);
                
                break;

                case "D":
                    pen = bc * 0.04;
                    eps = bc * 0.04;
                    double salareal = sal - (arl + pen + eps);
                    Console.WriteLine("las deudaciones que recibira son: ");
                    Console.WriteLine("Arl: " + arl);
                    Console.WriteLine("Eps: " + eps);
                    Console.WriteLine("Pen: " + pen);
                    Console.WriteLine("Salario real: " + salareal );
                    Console.WriteLine("Salario anual: " +( (salareal * 12) + bon));
                    break;
            }
        }
    }
}
