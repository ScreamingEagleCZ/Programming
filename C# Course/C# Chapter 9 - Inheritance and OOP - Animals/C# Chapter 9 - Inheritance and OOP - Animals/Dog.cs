using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Chapter_9___Inheritance_and_OOP___Animals
{
    internal class Dog : Animal
    {
        public bool Happy {  get; set; }
        public Dog(string name, int age) : base(name,age)
        {
            Happy = true;   // All dogs are happy
        }
        public override void Eat()
        {
            // To call the eat method from base class we use keyword "base"
            base.Eat();
        }
        public override void MakeSound()
        {
            // Since every animal make different sound 
            // each animal will implement own version of MakeSound
            Console.WriteLine("Woof! Woof!");
        }
        public override void Play()
        {
            if (Happy)
            {
                base.Play();
            } else
            {
                Console.WriteLine($"{Name} is not really in mood for playing... :/");
            }

        }
    }
}
