using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Chapter10_Polymorphism
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // Has a relationship (CarIdInfo class)
        protected CarIdInfo carIdInfo = new CarIdInfo();
        public void SetCarIdInfo(int idNum, string owner)
        {
            carIdInfo.IDNum = idNum;
            carIdInfo.Owner = owner;
        }
        public void GetCarIdInfo()
        {
            Console.WriteLine($"The car has the ID: {carIdInfo.IDNum} and is owned by {carIdInfo.Owner}");
        }

        public Car(int hp, string color)
        { 
            this.HP = hp; 
            this.Color = color; 
        }
        public new void ShowDetails()   // Clasic definition of base function - deriving function can use "new" to override this one
            // will only be called if object is created as deriving class and not base one (created as BMW not Car)
        {
            Console.WriteLine($"Power: {HP}, Color: {Color}");
        }
        public virtual void Repair()    // Virtual allows derivving classes to override function by theirs
        {
            Console.WriteLine("Car was repaired...");
        }
        public virtual void Start()
        {
            Console.WriteLine("Car has started...");
        }
        public virtual void Drift()
        {
            Console.WriteLine("Car is Drifting!!!");
        }
    }
}
