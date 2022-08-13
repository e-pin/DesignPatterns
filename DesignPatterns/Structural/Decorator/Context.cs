using DesignPatterns.Structural.Decorator.Component;
using DesignPatterns.Structural.Decorator.ConcreteComponents;
using DesignPatterns.Structural.Decorator.ConcreteDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public static class Context
    {
        public static void Demo()
        {
            Console.WriteLine("Testing Decorator Pattern");

            Pizza pizza = new MediumPizza();
            pizza = new Cheese(pizza);
            pizza = new Ham(pizza);
            pizza = new Peppers(pizza);

            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine($"{pizza.CalculateCost():C2}");
        }
    }
}
