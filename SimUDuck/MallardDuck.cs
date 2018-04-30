using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _quackBehavior = new QuackBehavior.Quack();
            _flyBehavior = new FlyBehavior.FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
