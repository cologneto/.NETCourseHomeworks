using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_AngledTriangleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter triagles side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter triagles side b: ");
            double b = double.Parse(Console.ReadLine());
            
            var triangle = new RightAngledTriangle(a, b);
            triangle.FindHypotenuse();
            triangle.FindAngles();

            
        }
    }
}
