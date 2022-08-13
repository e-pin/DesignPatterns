using DesignPatterns.Structural.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.ConcreteComponents
{
    internal class LargePizza : Pizza
    {
        public LargePizza()
        {
            Description = "Large Pizza";
        }
        public override double CalculateCost()
        {
            return 9.00;
        }

        public override string GetDescription()
        {
            return "Large Pizza";
        }
    }
}
