using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Chapter10_Abstract
{
    abstract class Shape    // its not possible to create object of abstract class in main program
    {
        public string Name { get; set; }

        public virtual void GetInfo()   // virtual allows overriding from derived classes
        {
            Console.WriteLine($"\nThis is a {Name}");
        }
        public abstract double Volume();    // NOT IMPLEMENTED METHOD! - Deriving class has to implement this functionality by itself
    }
}
