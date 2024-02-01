using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Chapter6_OOP
{
    internal class Car
    {
        // Private Member Variables/fields
        private string _name; // Private field .. typically for storing data
        private int _hp;
        private string _color;



        // Auto implemented property
        public int Year { get; set; }   // also contains internal variable Year which doesnt has to be defined above
        public int MaxSpeed { get; } = 320; // This one can only be read not setted   
        

        // Public property
        //public string Name { get { return _name; } set { _name = value; } } - same as below but shorter 
        public string Name { 
            get { return _name; } // Get accessor
            set { _name = value; }  //Set accessor
        }
        // Constructor (default) - will be called upon creating of object...
        public Car() 
        {
            _name = "Car";
            _hp = 0;
            _color = "Rusty";
            Console.WriteLine($"{_name} was created...");
        }
        // Partial Specification Constructor
        public Car(string name, int hp) // Requires name and hp
        {
            _name = name;
            Console.WriteLine($"{_name} was created...");
            _hp = hp;
            _color = "Generic";
        }
        // Full Specification Constructor
        public Car(string name, int hp, string color) // Requires name and optional hp - default value 0 if none is given
        {
            _name = name;
            Console.WriteLine($"{_name} was created...");
            _hp = hp;
            _color = color;
        }
        // Optional Specification Constructor with default values - this one should stand alone - when upper constructors are not defined
        /*
        public Car(string name, int hp = 0, string color = "Black") // Requires name and optional hp, color - default value 0/Black if none is given
        {
            _name = name;
            Console.WriteLine($"{_name} was created...");
            _hp = hp;
            _color = color;
        }
        */
        // Member Methods
        public void Drive() 
        { 
            Console.WriteLine($"{_name} is driving...");
        }
        public void Stop() 
        {
            Console.WriteLine($"{_name} stopped...");
        }
        public void Specs()
        {
            Console.WriteLine($"Model: {_name}, Power: {_hp} hp, Color: {_color}");
            Console.WriteLine("");
        }
        // Setter methods - to access private variables
        public void setName(string name) 
        {
            if ( name != "" )
            {
                Console.WriteLine($"{_name} will be renamed to {name}...");
                _name = name;
            } else {
                Console.WriteLine($"{_name} will be set to default name...");
                _name = "Car";
            }

        }
        // Getter methods - to read from private variable
        public string GetName() 
        { 
            return _name; 
        }
        public string GetHp()
        {
            return _hp + "hp";
        }
        // Destructor - only one can exist , cannot be inherited/ overloaded
        ~Car()
        {
            // Clean Up Statements - should only be used when needed to save processing power
            Console.WriteLine("Deconstruction of Member objects...");
        }

    }
}
