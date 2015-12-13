using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    class SUV : Car
    {
        public bool IsAllRoad { get; set; }

        public SUV()
        {
            this.IsAllRoad = IsAllRoad;
        }

        public override string ToString()
        {
            return (IsAllRoad ? "This car is SUV and it is allroad" : "This car is SUV and it is not for allroads");
        }
    }
}
