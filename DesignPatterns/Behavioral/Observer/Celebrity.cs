using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Celebrity : ICelebrity
    {
        List<IObserver> observers = new List<IObserver>();
        private int flag;
        public int Flag
        {
            get { return flag; }
            set
            {
                flag = value;
                // Flag value changed, so notify observers
                NotifyRegisteredUsers();
            }
        }

        private string name;
        public Celebrity(string name)
        {
            this.name = name;
        }
        public string Name => name;

        public void Register(IObserver o)
        {
            observers.Add(o);
        }

        public void UnRegister(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyRegisteredUsers()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}
