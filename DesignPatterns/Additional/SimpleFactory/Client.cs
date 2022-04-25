using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Additional.SimpleFactory
{
    public class Client
    {
        public static void Demo()
        {
            Console.WriteLine("*** Simple Factory Pattern Demo.***\n");
            IAnimal preferredType = null;
            SimpleFactory factory = new SimpleFactory();
            #region The code region that can vary based on users preference
            /*
            * Since this part may vary,we're moving the
            * part to CreateAnimal() in SimpleFactory class.
            */
            preferredType = factory.CreateAnimal();
            #endregion
            
            // Code that does not change frequently
            preferredType.AboutMe();
        }
    }
}
