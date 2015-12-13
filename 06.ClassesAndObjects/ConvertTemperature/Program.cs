using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTemperature
{
    class Program
    {
        static void Main(string[] args)
        {

            ConvertCelsiusToFahrenheit a = new ConvertCelsiusToFahrenheit();
            Console.Write("Please enter Celsius temperature: ");
            a.TempInCelsius = double.Parse(Console.ReadLine());
            
            a.TempFromCelsiusToFahrenheit();
        }
    }
}
