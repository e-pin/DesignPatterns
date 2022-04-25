using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Additional.SimpleFactory
{
    public class SimpleFactory
    {
        public  IAnimal CreateAnimal()
        {
            IAnimal animal = null;
            Console.WriteLine("Enter your choice: 0 for a Dog, 1  for a Tiger");
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    animal = new Dog();
                    break;

                case "1":
                    animal = new Tiger();
                    break;

                default:
                    Console.WriteLine("You must enter either 0 or 1");
                    //We'll throw a runtime exception for any other
                    //choices.
                    throw new ApplicationException(" Unknown Animal cannot be instantiated ");
                    break;
            }

            return animal;
        }
    }
}
