using Strategy.Behavior;
using Strategy.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Duck millardDuck = new MillardDuck();
            millardDuck.PerformFly();
            millardDuck.PerformQuack();

            Duck modelDuck = new ModelDuck();
            modelDuck.PerformFly();
            modelDuck.SetFlyBehavior(new FlyRocketPowered());
            modelDuck.PerformFly();

            Console.ReadLine();
        }
    }
}
