using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Vehicle
    {
        VehicleBehavior vehicleBehavior;
        string vehicleType;

        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
            // setting initial behavior
            this.vehicleBehavior = new InitialBehavior();
        }

        public void SetBehavior(VehicleBehavior vehicleBehavior)
        {
            if (vehicleBehavior == null)
            {
                throw new ArgumentNullException();
            }
            this.vehicleBehavior = vehicleBehavior;
        }

        public void DisplayAboutMe()
        {
            vehicleBehavior.AboutMe(vehicleType);
        }
    }
}
