using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_AngledTriangleClass
{
    class RightAngledTriangle
    {
        public double ASide { get; set; }
        public double BSide { get; set; }

        public RightAngledTriangle(double a, double b)
        {
            this.ASide = a;
            this.BSide = b;
        }

        public void FindHypotenuse()
        {

            var hyp = Math.Sqrt(Math.Pow(this.ASide, 2) + Math.Pow(this.BSide, 2));

            Console.WriteLine("The Hypotenuse is {0} millimeters long", hyp);
        }

        public void FindAngles()
        {
            var angleOppositeA = Math.Atan(this.ASide / this.BSide) * (180 / Math.PI);
            var angleOppositeB = Math.Atan(this.BSide / this.ASide) * (180 / Math.PI);

            Console.WriteLine("The other two angles are:\n Opposite A side: {0};\n Opposite B side: {1};\n", angleOppositeA, angleOppositeB);
        }
    }
}
