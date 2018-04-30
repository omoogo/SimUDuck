using System;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();

            mallard.PerformQuack();
            Console.WriteLine();
            mallard.PerformFly();

            Console.ReadLine();
        }
    }
}
