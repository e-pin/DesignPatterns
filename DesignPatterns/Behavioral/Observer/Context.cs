using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public static class Context
    {
        public static void Demo()
        {
            Console.WriteLine("***Observer Pattern Demo***");
            // We have 4 obsservers: 1 is ObserverType1 and 2 are 

            IObserver observer1 = new ObserverType1("Mario");
            IObserver observer2 = new ObserverType1("Luca");
            IObserver observer3 = new ObserverType2("Anna");
            IObserver observer4 = new ObserverType2("Lucia");

            Console.WriteLine("Working with the first celebrity now");
            ICelebrity celebrity = new Celebrity("Celebrity-1");

            // Registering the first three observers
            celebrity.Register(observer1);
            celebrity.Register(observer2);
            celebrity.Register(observer3);

            Console.WriteLine("Celebrity-1 is setting flag = 5");
            celebrity.Flag = 5;

            /* Mario doesn't want to get other notifications.
             * Unregistering the observer Mario */
            Console.WriteLine("Celebrity-1 is removing Mario from the observers list now");
            celebrity.UnRegister(observer1);

            // No notification was sent to Mario. He has unsubscibed now.

            Console.WriteLine("Celebrity-1 is setting flag = 10");
            celebrity.Flag = 10;

            // Mario is registering himself again
            celebrity.Register(observer1);

            Console.WriteLine("Celebrity-1 is setting flag = 100");
            celebrity.Flag = 100;

            Console.WriteLine("Working with celebrity 2 now");

            // Creating another celeb
            ICelebrity celebrity2 = new Celebrity("Celebrity-2");

            // Registering the observers Luca and Lucia
            celebrity2.Register(observer2);
            celebrity2.Register(observer4);

            Console.WriteLine("Celebrity 2 is setting the flag = 7");
            celebrity2.Flag = 7;

            Console.WriteLine("***End of Demo***");

            Console.WriteLine("init new demo");



        }
    }
}
