using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIOS");
             
            int N1 = 50;
            int N2 = 10;
            int Suma;
            Suma = N1 + N2;

            Console.WriteLine("La suma de {0} y {1} es {2}", N1, N2, Suma);

            int Resta;
            Resta = N1 - N2;

            Console.WriteLine("La resta de {0} y {1} es {2}", N1, N2, Resta);

            int Multiplicacion;
            Multiplicacion = N1 * N2;

            Console.WriteLine("{2} es la multiplicacion entre {0} y {1}", N1, N2, Multiplicacion);

            int Division;
            Division = N1 / N2;

            Console.WriteLine("{0} dividido en {1} es {2}", N1, N2, Division);

            Console.WriteLine("PERSONAS");

            string[] Personas = new string [5];
            Personas[0] = "Eugenio";
            Personas[1] = "Emma";
            Personas[2] = "Lorenzo";
            Personas[3] = "Ricardo";
            Personas[4] = "Veronica";


            Console.WriteLine("{0} es muy persistente en sus labores", Personas[0]);
            Console.WriteLine("{0} es timida en frente de muchas personas", Personas[1]);
            Console.WriteLine("{0} es un gran futbolista", Personas[2]);
            Console.WriteLine("{0} es un buen cantante de Rock", Personas[3]);
            Console.WriteLine("{0} es una magnifica cocinera", Personas[4]);

            






        }
    }
}
