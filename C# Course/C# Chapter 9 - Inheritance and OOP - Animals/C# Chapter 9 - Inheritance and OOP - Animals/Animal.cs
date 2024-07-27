using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Chapter_9___Inheritance_and_OOP___Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Hungry { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            Hungry = true;  // Al animals are initially hungry by default :D
        }
        public virtual void MakeSound()  // Virtual says it can be overridden by inherriting classes (sound is different from animal to animal)
        {
            Console.WriteLine($"{Name} is making sound...");
        }
        public virtual void Eat()
        {
            if (Hungry)
            {
                Console.WriteLine($"{Name} is eating...");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry...");
            }

        }
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing...");
        }
    }

}
