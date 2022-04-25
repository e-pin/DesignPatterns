using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class ObserverType3 : IObserver
    {
        string nameOfObserver;

        public ObserverType3(string name)
        {
            nameOfObserver = name;
        }
        public void Update(ICelebrity subject)
        {
            Console.WriteLine("{0} received message: {1}", nameOfObserver, subject.Name);
        }
    }
}
