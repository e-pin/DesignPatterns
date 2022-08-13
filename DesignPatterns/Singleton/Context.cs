using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public static class SingletonContext
    {
        public static void Demo()
        {
            Client client = Client.Instance;
            Console.WriteLine(client.GetHashCode());
        }
    }
}
