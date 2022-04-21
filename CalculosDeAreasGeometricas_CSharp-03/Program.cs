using System;
using System.Globalization;

namespace CalculosDeAreasGeometricas_CSharp_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            Console.WriteLine("Digite os valores de A, B e C:");
            string[] val = Console.ReadLine().Split(' ');
            A = double.Parse(val[0], CultureInfo.InvariantCulture);
            B = double.Parse(val[1], CultureInfo.InvariantCulture);
            C = double.Parse(val[2], CultureInfo.InvariantCulture);


            triangulo = A * C / 2.0;
            circulo = 3.14159 * Math.Pow(C, 2);
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine();
            Console.WriteLine("Os valores das áreas são:");
            Console.WriteLine("TRIÂNGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
