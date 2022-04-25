using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            // Creating a Tiger
            return new Tiger();
        }
    }
}
