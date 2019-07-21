using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        //Manuela Urrea Ferrer

        //Ejercicio 1
        Console.WriteLine("Solucíon de triangulos: #1");
        double Yy = 2;
        double Zz = 3;

        double Tt = Math.Sqrt((Yy * Yy) + (Zz * Zz));
        double Cc = (Math.Atan(Zz / Yy)) * (180 / Math.PI);
        double Aa = (Math.Atan(Yy / Zz))*(180/Math.PI);

        Console.WriteLine("t =" + Tt);
        Console.WriteLine("c =" + Cc);
        Console.WriteLine("a =" + Aa);

        //Ejercicio 2
        Console.WriteLine("Solucíon de triangulos: #2");
        double t = 3.61;
        double a = 33.69;

        double y = t * (Math.Sin(a * (Math.PI/180.0)));
        double z = Math.Sqrt((t * t) - (y * y));
        double c = 180-(90 + a);

        Console.WriteLine("y =" + y);
        Console.WriteLine("z =" + z);
        Console.WriteLine("c =" + c);

        //Ejercicio 3
        Console.WriteLine("Solucíon de triangulos: #3");
        double C = 56.31;
        double Z = 3;

        double A = 180- (90 + C);
        double T = Z / Math.Sin(C * (Math.PI/180.0));
        double Y = T * Math.Sin(A); 

        Console.WriteLine("a =" + A);
        Console.WriteLine("t =" + T);
        Console.WriteLine("y =" + Y);


    }
}

