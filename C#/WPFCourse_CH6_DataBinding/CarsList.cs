using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCourse_CH6_DataBinding
{
    internal class CarsList
    {
        public static List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car(){Owner="Mike", Brand=Cars.Ford, Model=Model.Mustang},
                new Car(){Owner="Gomez", Brand=Cars.Dodge, Model=Model.Charger },
                new Car(){Owner="Jebedyah", Brand=Cars.Chevrolet, Model = Model.Corvette},
                new Car(){Owner="SumTingWong", Brand=Cars.Nissan, Model = Model.Skyline},
                new Car(){Owner="Takumi", Brand=Cars.Toyota, Model = Model.GT_86}
            }.ToList();
        }
    }
}
