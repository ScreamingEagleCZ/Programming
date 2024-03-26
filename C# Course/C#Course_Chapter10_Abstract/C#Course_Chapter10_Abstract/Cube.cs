using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Chapter10_Abstract
{
    internal class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double length)
        {
            Name = "Cube";
            Length = length;
        }
        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }
        public override void GetInfo()   // virtual allows overriding from derived classes
        {
            base.GetInfo();
            Console.WriteLine($"The cube has a length of {Length}");
            Console.WriteLine($"Volume of cube is {Volume()}");
        }
    }
}
