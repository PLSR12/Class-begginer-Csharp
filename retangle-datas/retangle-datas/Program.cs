using System;
using System.Globalization;

namespace retangle_datas {
    class Program
{
    static void Main(string[] args)
    {
        Retangle retangle = new Retangle();

        Console.WriteLine("Entre a largura e altura do retangulo :");
        retangle.width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        retangle.height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + retangle.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + retangle.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + retangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
}
}
