using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class ObserverType1 : IObserver
    {
        string nameOfObserver;

        public ObserverType1(string name)
        {
            this.nameOfObserver = name;
        }

        public void Update(ICelebrity celeb)
        {
            Console.WriteLine($"{nameOfObserver} has received an update from {celeb.Name}. The updated value is {celeb.Flag }");
        }
    }
}
