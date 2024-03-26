using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Chapter10_Polymorphism
{
    class Nissan : Car
    {
        public string Brand = "Nissan";
        public string Model { get; set; }

        public Nissan(int hp, string color, string model) : base(hp, color)  // base uses constructor from base class (Car)
        {
            this.Model = model;
        }
        public void ShowDetails()   // Base default funtion will be used because override is missing here
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Power: {HP}, Color: {Color}");
        }
        public void Repair()    // "new" - This will be prioritizing this function over base one
        {
            Console.WriteLine("The Nissan {0} was repaired...", Model);
        }
        public override void Start()
        {
            Console.WriteLine("Nissan has started...");
        }
        public sealed override void Drift() // "sealed" restricts deriviing classes  methods from overriding this method
        {
            Console.WriteLine("Nissan is Drifting!!!");
        }
    }
}
