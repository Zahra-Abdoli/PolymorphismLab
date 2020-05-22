using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Peter", "Whiskas");
            Animal dog = new Dog("Gunnar", "Meat");

            Console.WriteLine(cat.Explainself());
            Console.WriteLine(dog.Explainself());

        }
    }
}
