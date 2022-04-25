using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class ObserverType2 : IObserver
    {
        string nameOfObserver;

        public ObserverType2(string name)
        {
            this.nameOfObserver = name;
        }
        public void Update(ICelebrity celeb)
        {
            Console.WriteLine($"{nameOfObserver} notified. Inside {celeb.Name}, the updated value is: {celeb.Flag}");
        }
    }
}
