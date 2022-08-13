using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Client
    {
        public static Client client;
        private Client()
        {

        }

        public static Client Instance
        {
            get
            {
                if (client == null)
                {
                    client = new Client();
                }
                return client;
            }
        }
    }
}
