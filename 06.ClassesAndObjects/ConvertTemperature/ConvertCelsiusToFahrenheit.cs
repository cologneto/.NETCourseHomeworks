using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTemperature
{
    class ConvertCelsiusToFahrenheit
    {
        public double TempInCelsius { get; set; }

        public ConvertCelsiusToFahrenheit() 
        {
            this.TempInCelsius = TempInCelsius;
        }

        public void TempFromCelsiusToFahrenheit() 
        {
            var tempFahrenheit = ((9.0 / 5.0) * this.TempInCelsius) + 32; 
            Console.WriteLine("Temp {0} in C = Temp {1} in F.", this.TempInCelsius, tempFahrenheit);
        }
    }
}
