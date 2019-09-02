using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 15, 6, 12, 3, 18, 12, 6, 9 };
            int[] B = { 4, 0, 18, 6, 16, 6, 10, 14, 2, 12, 8, 2 };
            int[] U = new int[31];

            for (int i = 0; i < U.Length; i++) U[i] = i;

            //datos
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + ",");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i] + ",");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < U.Length; i++)
            {
                Console.Write(U[i] + ",");
            }
            Console.WriteLine(" ");

            int[] norepetidosA = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                norepetidosA[i] = -1;
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(" ");
                for (int k = 0; k < norepetidosA.Length; k++)
                {
                    Console.Write(norepetidosA[k] + ",");
                }

                int datoactual = A[i];
                bool repetido = false;
                for (int j = 0; j < norepetidosA.Length; j++)
                {
                    if (datoactual == norepetidosA[j])
                    {
                        repetido = true;
                        break;
                    }
                }
                if (!repetido)
                {
                    norepetidosA[i] = datoactual;
                }
            }
            int contador2 = 0;
            for (int k = 0; k < norepetidosA.Length; k++)
            {
                if (norepetidosA[k] != -1)
                {
                    contador2 += 1;
                }
            }
            Console.WriteLine("Total no repetidos de A:  " + contador2);

            int[] norepetidos = new int[B.Length];
            for (int i = 0; i < B.Length; i++)
            {
                norepetidos[i] = -1;
            }

            for (int i = 0; i < B.Length; i++) {
                Console.WriteLine(" ");
                for (int k = 0; k < norepetidos.Length; k++)
                {
                    Console.Write(norepetidos[k] + ",");
                }

                int datoactual = B[i];
                bool repetido = false;
                for (int j = 0; j < norepetidos.Length; j++)
                {
                    if (datoactual == norepetidos[j])
                    {
                        repetido = true;
                        break;
                    }
                }
                if (!repetido)
                {
                    norepetidos[i] = datoactual;
                }
            }
            int contador = 0;
            for (int k = 0; k < norepetidos.Length; k++)
            {
                if (norepetidos[k] != -1)
                {
                    contador += 1;
                }
            }
            Console.WriteLine("Total no repetidos de B:  " + contador);

            Console.WriteLine(" ");
            List<int> union = new List<int>();
            for (int i = 0; i < A.Length; i++) union.Add(norepetidosA[i]);
            for (int i = 0; i < B.Length; i++) union.Add(norepetidos[i]);
            union.Sort();
            for (int i = 0; i < union.Count-1; i++)
            {
                if(union[i] == union[i+1])
                {
                    union.RemoveAt(i);
                    i = 0; 
                }
                if (union[i] == -1)
                {
                    union.RemoveAt(i);
                    i = 0;
                }
                   
            }

            Console.WriteLine("La union de los conjuntos A y B es: ");
            for (int i = 0; i < union.Count; i++)
            {
                Console.Write( union[i] + ",");
            }

        }
    }
}
