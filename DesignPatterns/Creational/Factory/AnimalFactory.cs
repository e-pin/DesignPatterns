using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public abstract class AnimalFactory
    {
        public IAnimal MakeAnimal()
        {
            Console.WriteLine("AnimalFactory.MakeAnimal()-You cannot ignore parent rules.");
            IAnimal animal = CreateAnimal();
            animal.AboutMe();
            return animal;
        }


        /*
        The GoF definition says
        "....Factory method lets a class defer instantiation
        to subclasses." The following method will create a tiger or a dog
        object, but at this point it does not know whether it will get a
        dog or a tiger. It will be decided by
        the subclasses i.e. DogFactory or TigerFactory.
        So, the following method is acting like a factory
        (of creation).
        */
        public abstract IAnimal CreateAnimal();
    }
}
