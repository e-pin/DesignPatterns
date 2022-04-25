using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class DogFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            // Creating a dog
            return new Dog();
        }
    }
}
