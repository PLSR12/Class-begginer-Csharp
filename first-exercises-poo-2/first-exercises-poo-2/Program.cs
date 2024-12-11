using System;
using System.Globalization;

namespace first_exercises_poo_2 {
    class Program {
        static void Main(string[] args) { 
           Employe employeOne = new Employe();
           Employe employeTwo = new Employe();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.WriteLine("Nome:");
            employeOne.name = Console.ReadLine();
            Console.WriteLine("Salario:");
            employeOne.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.WriteLine("Nome:");
            employeTwo.name = Console.ReadLine();
            Console.WriteLine("Salario:");
            employeTwo.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salaryMedium = (employeOne.salary + employeTwo.salary) / 2;

            Console.WriteLine("Salario medio = " + salaryMedium.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
