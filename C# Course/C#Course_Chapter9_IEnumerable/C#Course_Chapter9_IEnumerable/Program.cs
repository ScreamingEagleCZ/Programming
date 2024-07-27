using System.Collections;

namespace C_Course_Chapter9_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();
            // To be able to enumerate (get each) u need to implement IEnumerate Interface lower in class
            foreach (Dog dog in shelter)   
            {
                if (!dog.IsNaughtyDog) 
                {
                    dog.GiveTreat(2);
                } else
                {
                    dog.GiveTreat(1);
                }
            }
        } 
    }
    class Dog
    {
        // The name of the dog
        public string Name { get; set; }
        // Is this a naughty dog
        public bool IsNaughtyDog { get; set; }
        // Simple constructor
        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }
        public void GiveTreat(int numberOfTreats)
        {
            // Print message containing number of treats and the name of the dog
            Console.WriteLine("The doggo {0} woofed {1} times!", Name, numberOfTreats);
        }
    }
    // IEnumerable allows us to enumerate when using foreach loop above
    class DogShelter : IEnumerable<Dog>
    {
        // List of type List<Dog>
        public List<Dog> dogs;
        // This constructor will initialize the dogs list with some values
        public DogShelter()
        {
            // Initialize the dogs list using the collection-initializer
            dogs = new List<Dog>()
            {
                new Dog("Zoe", false),
                new Dog("Caesar", true),
                new Dog("Wulfie", false),
                new Dog("Bertha", false),
                new Dog("Johny", true),
                new Dog("Pixie", false),
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            //throw new NotImplementedException(); - has to be rewrited to lower
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
