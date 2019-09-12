using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;


    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        //Contar la cantidad de estudiantes con nota entre el promedio y +/- la desviación estandár de todos los estudiantes
        double total = 0;
        double sumatoria = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }
        double promedio = total / notas.Length;
        for (int i = 0; i < notas.Length; i++)
        {
            double xi = notas[i];
            sumatoria += Math.Pow((xi - promedio), 2);
        }
        Console.WriteLine("sumat" + sumatoria);
        double d = Math.Sqrt(sumatoria / notas.Length);
        Console.WriteLine("prom" + promedio);
        Console.WriteLine("desv" + d);
        Console.WriteLine("+" + (promedio + d));
        Console.WriteLine("-" + (promedio - d));
        for (int i = 0; i < notas.Length; i++)
        {
            if ((promedio - d) <= notas[i])
            {
                if (notas[i] <= (promedio + d))
                {
                    salida++;
                }
            }
        }



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
 

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        //Encontrar los nombres de las personas con nota entre el promedio +/- la desviación estándar y almacenarlos en el arreglo salida.
        double total = 0;
        double sumatoria = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }
        double promedio = total / notas.Length;
        for (int i = 0; i < notas.Length; i++)
        {
            double xi = notas[i];
            sumatoria += Math.Pow((xi - promedio), 2);
        }
        Console.WriteLine("sumat" + sumatoria);
        double d = Math.Sqrt(sumatoria / notas.Length);
        Console.WriteLine("prom" + promedio);
        Console.WriteLine("desv" + d);
        Console.WriteLine("+" + (promedio + d));
        Console.WriteLine("-" + (promedio - d));
        for (int i = 0; i < notas.Length; i++)
        {
            if ((promedio - d) <= notas[i])
            {
                if (notas[i] <= (promedio + d))
                {
                    salida.Add(nombres[i]);
                }
            }
        }



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        //Encontrar los nombres de los estudiantes cuyo nombre tiene por lo menos dos letras A.
        for (int i = 0; i < nombres.Length; i++)
        {
            double contieneA = 0;
            for (int j = 0; j <= nombres[i].Length - 1; j++)
            {

                string nombre = nombres[i];
                if (nombre[j] == 'A')
                {
                    contieneA++;
                }

                if (contieneA >= 2)
                {
                    salida.Add(nombres[i]);
                    break;
                }

            }
            Console.WriteLine("cuantas a tiene: " + contieneA);
        }




        //- Arriba de esta línea va su código --------
        return salida;
    }
}


