using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Chapter10_Polymorphism
{
    class BMW : Car
    {
        public string Brand = "BMW";
        public string Model {  get; set; }

        public BMW(int hp, string color, string model):base(hp, color)  // base uses constructor from base class (Car)
        {
            this.Model = model;
        }
        public void ShowDetails()  // Override allows to use this instead of base virtual function
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Power: {HP}, Color: {Color}");
        }
        public override void Repair()   // Override allows to use this instead of base virtual function
        {
            Console.WriteLine("The BMW {0} was repaired...", Model);
        }
    }
}
