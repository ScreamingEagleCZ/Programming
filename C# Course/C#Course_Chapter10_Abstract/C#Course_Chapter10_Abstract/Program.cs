namespace C_Course_Chapter10_Abstract
{
    internal class Program
    {   // In shape class is placeholder method which has to be implemented in deriving classes method
        static void Main(string[] args)
        {
            Shape[] shapes = { new Cube(3), new Sphere(4) };
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Cube iceCube = shape as Cube;   // tryes to create object as Cube object - Cube as Cube and later Sphere as Cube
                if (iceCube == null)    // if its null == its not Cube (when trying to make Cube from Sphere it will be null)
                {
                    Console.WriteLine("This shape is not a cube...");
                }
                if (shape is Cube)  // if its Cube (true when making Cube from Cube, not when making Cube from Sphere)
                {
                    Console.WriteLine("This shape is a cube...");
                }
            }



            Console.ReadKey();
        }
    }
}
