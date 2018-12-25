using Strategy.IBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavior
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quackk()
        {
            Console.WriteLine("Silence!");
        }
    }
}
