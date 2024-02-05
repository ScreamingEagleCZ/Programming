namespace C__Chapter_9___Inheritance_and_OOP___Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Zebra = new Animal("Marty", 4);
            Dog dog = new Dog("Doggo", 9);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old.");
            dog.Play();
            dog.Hungry = false;
            dog.Eat();
            dog.MakeSound();
            dog.Happy = false;
            dog.Play();

        }
    }
}
