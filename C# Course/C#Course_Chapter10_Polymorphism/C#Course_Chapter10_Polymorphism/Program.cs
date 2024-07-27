namespace C_Course_Chapter10_Polymorphism
{
    internal class Program
    {
        // Polymorphism allows to use derivved functions in derrived class instead of base class functions
        // Base function/class has to be virtual (public virtual void Function())
        // and Deriiving function/class has to use override (public override void Function())
        // "new" - public new void Repair() - in deriving class/function will prioritize it
        // over base function - no need to use "virtual" keyword
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Nissan(200, "White", "240SX"),
                new BMW(280, "Yellow Acid", "M4")
            };
            foreach (var car in cars) 
            {
                car.Repair();
                car.ShowDetails();
                // more specified Repair info only when showing BMW - it overrides base function
                // show details will be base ones for both because both objects created as "car"
            }
            Console.ReadKey();
            BMW bmwM3 = new BMW(450, "Black", "M3");
            bmwM3.ShowDetails();    // mode detailed info will be shown using "new" because object created as deriving class (BMW not car)
            Console.ReadKey();

            GTR nissanGTR = new GTR(750, "Silver", "GTR");
            nissanGTR.Start();
            Console.ReadKey();

            cars[1].Drift();
            nissanGTR.Drift();
            Console.ReadKey();

            cars[0].SetCarIdInfo(7854, "Jakub Muky");
            nissanGTR.SetCarIdInfo(6666, "Jebedyah Kerman");
            cars[0].GetCarIdInfo();
            cars[1].GetCarIdInfo();
            nissanGTR.GetCarIdInfo();
            Console.ReadKey();
        }
    }
}
