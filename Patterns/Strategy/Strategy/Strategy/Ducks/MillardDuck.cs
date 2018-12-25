using Strategy.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    public class MillardDuck : Duck
    {
        public MillardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm real Millard dcuk");
        }
    }
}
