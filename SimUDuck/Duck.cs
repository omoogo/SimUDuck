using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimUDuck.FlyBehavior;
using SimUDuck.QuackBehavior;

namespace SimUDuck
{
    public abstract class Duck
    {
        public IFlyBehavior _flyBehavior;
        public IQuackBehavior _quackBehavior;

        public Duck()
        {

        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
           _flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public abstract void Display();

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
