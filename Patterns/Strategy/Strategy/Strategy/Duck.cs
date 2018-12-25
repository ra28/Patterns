using Strategy.IBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public Duck()
        {
        }

        public void SetFlyBehavior(IFlyBehavior fBehavior)
        {
            flyBehavior = fBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior qBehavior)
        {
            quackBehavior = qBehavior;
        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quackk();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float.");
        }


    }
}
