using DesignPatterns.Structural.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.ConcreteComponents
{
    public class MediumPizza : Pizza
    {
        public MediumPizza()
        {
            Description = "Medium Pizza";
        }

        public override double CalculateCost()
        {
            return 6.00;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
