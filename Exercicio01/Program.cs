using System;
using System.Globalization;

namespace Exercicio01 {
    class Program {
        static void Main(string[] args) {

            Retangulo R = new Retangulo();

            Console.WriteLine("Entre com a largura do retângulo: ");
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com a altura do retângulo: ");
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine();
            Console.WriteLine("Area: " + R.Area().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Perimetro: " + R.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Diagonal: " + R.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}