using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Person PersonOne = new Person();
            Person PersonTwo = new Person();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome:");
            PersonOne.name = Console.ReadLine();
            Console.WriteLine("Idade:");
            PersonOne.age = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome:");
            PersonTwo.name = Console.ReadLine();
            Console.WriteLine("Idade:");
            PersonTwo.age = int.Parse(Console.ReadLine());

            if(PersonOne.age > PersonTwo.age)
            {
                Console.WriteLine("Pessoa mais velha : " + PersonOne.age);
            } else
            {
                Console.WriteLine("Pessoa mais velha : " + PersonTwo.age);

            }
        }
    }
}