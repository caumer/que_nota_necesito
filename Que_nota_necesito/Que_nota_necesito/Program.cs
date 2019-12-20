using System;

namespace que_nota_necesito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota del certamen 1");
            int certamen1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del certamen 2");
            int certamen2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del laboratorio");
            int laboratorio = int.Parse(Console.ReadLine());

            decimal notaLaboratorio = laboratorio * 0.3m;
            decimal notaCertamen = (60 - notaLaboratorio) / (0.7m);

            decimal certamen3 = (3 * notaCertamen) - (certamen1 + certamen2);

            Console.WriteLine($"Necesita nota {Math.Round(certamen3)} en el certamen 3");

        }
    }
}