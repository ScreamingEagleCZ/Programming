using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Course___Chapter_9___Inheritance
{
    // Base class - Parent class
    internal class Gadget
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        public Gadget(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }
        public void SwitchOn()
        {
            IsOn = true;
        }
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
