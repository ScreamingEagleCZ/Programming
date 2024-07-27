using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Course___Chapter_9___Inheritance
{
    class TV : Gadget
    {
        public TV (bool isOn, string brand):base(isOn, brand)
        {

        }
        public void WatchTv()
        {
            if (IsOn) 
            {
                Console.WriteLine("You are watching the show!");
            } else
            {
                Console.WriteLine("Could be useful to switch it on first...");
            }
        }
    }
}
