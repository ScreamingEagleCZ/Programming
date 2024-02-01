namespace C_Course_Chapter6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Chapter 6 - OOP - Object Oriented Programming
            
            // A Class in C# is a blueprint for creating objects - it defines properties and methods for that object

            Car bmw = new Car("BMW M4", 550, "Onyx Black");    // Creating new object of class Car
            bmw.Drive();
            Car audi = new Car("Audi Quattro", 250); // Second object of class
            Console.WriteLine("Type '1' to Stop the car...");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                bmw.Stop();
            } else
            {
                Console.WriteLine("Car will drive forever...");
            }
            bmw.Specs();
            audi.Specs();
            Car hyunday = new Car();    // Default constructor used
            hyunday.Specs();
            Car dacia = new Car("Duster", 50);  // Partial constructor used
            dacia.Specs();
            Car nissan = new Car("Nissan GTR", 750, "Sky Blue");    // Full Specs Constructor used
            nissan.Specs();
            nissan.setName("Hnissan");
            nissan.Specs();
            nissan.setName("");
            nissan.Specs();
            Console.WriteLine($"The name of BMW class is {bmw.GetName()}");
            Console.WriteLine($"The power of BMW is {bmw.GetHp()}");
            bmw.Name = "Bawo";   // using set in public property
            bmw.Specs();
            Console.WriteLine(bmw.Name);    // using get in public property
            bmw.Year = 2022;             // using property { get; set; } (set in this case)
            Console.WriteLine($"{bmw.Name} was made in year {bmw.Year}...");     // { get; set; } againg (get in this case)
            Console.WriteLine($"Max Speed of {bmw.Name} is {bmw.MaxSpeed} km/h...");   // this one can only be GETted not setted { get; }
            audi.Specs();





        }
    }
}
