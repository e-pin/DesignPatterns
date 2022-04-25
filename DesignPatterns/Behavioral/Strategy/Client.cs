using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public static class Client
    {
        public static void Demo()
        {
            Console.WriteLine($"***Strategy Pattern Demo***");
            Vehicle vehicle = new Vehicle("Aeroplane");
            vehicle.DisplayAboutMe();
            // giving flying behavior
            Console.WriteLine("Giving the vehicle flying behavior");
            vehicle.SetBehavior(new FlyingBehavior());
            vehicle.DisplayAboutMe();
            // giving the vehicle floating behavior
            Console.WriteLine("Giving the vehicle floating behavior");
            vehicle.SetBehavior(new FloatingBehavior());
            vehicle.DisplayAboutMe();
            Console.WriteLine("***End of demo***");

        }
    }
}
