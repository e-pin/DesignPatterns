using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public static class Client
    {
        public static void Demo()
        {
            Console.WriteLine("***Factory Pattern Demo.***\n");
            // Creating a Tiger Factory
            AnimalFactory tigerFactory = new TigerFactory();
            // Creating a DogFactory
            AnimalFactory dogFactory = new DogFactory();

            #region first attempt
            // Creating a tiger using the Factory Method
            //IAnimal tiger = tigerFactory.CreateAnimal();
            //tiger.AboutMe();

            // Creating a dog using factory method
            //IAnimal dog = dogFactory.CreateAnimal();
            //dog.AboutMe();
            #endregion

            #region Second attempt
            IAnimal tiger = tigerFactory.MakeAnimal();

            IAnimal dog = dogFactory.MakeAnimal();
            #endregion


            Console.ReadKey();
        }
    }
}
