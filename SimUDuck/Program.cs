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
            
            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyBehavior.FlyRocketPowered());
            model.PerformFly();

            Console.ReadLine();
        }
    }
}
