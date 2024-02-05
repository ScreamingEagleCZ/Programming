using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Course___Chapter_9___Inheritance
{
    // Child class - inheriting class
    class Radio : Gadget    //New class that inherits from Gadget
    {
        public Radio(bool isOn, string brand):base(isOn, brand) // :base says to save/pass properties to BASE CLASS during construction
        {
            // this.IsOn = isOn;  - no longer necessary
            // this.Brand = brand;  - no longer necessary
        }
        public void ListenToRadio()
        {
            if (IsOn) 
            { 
                Console.WriteLine("Enjoying the music!");
            } else { 
                Console.WriteLine("Radio is Off, switch it on first");
            }
        }
    }
}
