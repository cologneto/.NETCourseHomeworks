using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    class Automobile : Car
    {
        public int FuelConsumption { get; set; }

        public Automobile()
        {
            this.FuelConsumption = FuelConsumption;
        }

        public override string ToString()
        {
            return "This car is automobile and the fuel consumption is: " + FuelConsumption;
        }
    }
}
