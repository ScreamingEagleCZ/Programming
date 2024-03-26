using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Chapter10_Polymorphism
{
    internal class GTR : Nissan
    {
        public GTR(int hp, string color, string model):base(hp, color, model)
        {
            this.Model = model;
        }
        public override void Start()
        {
            base.Start();   // Will also call the "base"-"Nissan" method not Car method
        }
    }
}
