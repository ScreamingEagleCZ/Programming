using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Chapter10_Abstract
{
    internal class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }
        public override double Volume()
        {
            return Math.PI * (Math.Pow(Radius, 3)) * 4 / 3;
        }
        public override void GetInfo()   // virtual allows overriding from derived classes
        {
            base.GetInfo();
            Console.WriteLine($"The Sphere has a radius of {Radius}");
            Console.WriteLine($"Volume of Sphere is {Volume()}");
        }
    }
}
