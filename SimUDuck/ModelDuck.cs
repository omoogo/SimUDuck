using System;

namespace SimUDuck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyBehavior.FlyNoWay();
            _quackBehavior = new QuackBehavior.Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}