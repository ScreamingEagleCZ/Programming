namespace C_Course_Chapter11_DelegatesDemo
{
    internal class Program
    {
        //defining a delegate type called FilterDelegate that takes a
        //person object and returns bool
        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {
            //Create person objects
            Person p1 = new Person() { Name = "Jebedyah", Age = 68 };
            Person p2 = new Person() { Name = "Lula", Age = 26 };
            Person p3 = new Person() { Name = "Jax", Age = 37 };
            Person p4 = new Person() { Name = "Opie", Age = 12 };

            //add the objects to a list called people
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kiddies", people, IsChild);
            Console.WriteLine("************");
            DisplayPeople("Adultos", people, IsAdult);
            Console.WriteLine("************");
            DisplayPeople("Gerontos", people, IsSenior);
        }

        // a method to display the list of people that passes the filter condition
        //(returns true)
        //this method will take a title to be displayed, the list of people,
        //and a filter delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            //print the title
            Console.WriteLine(title);

            foreach (Person person in people) 
            {
                //check if this person passes the filter
                if (filter(person))
                {
                    Console.WriteLine("{0}, {1} years old", person.Name, person.Age);
                }
            }
        }
        //----------Filters-----------
        static bool IsAdult(Person person)
        {
            return person.Age >= 18;
        }
        static bool IsChild(Person person) 
        {
            return person.Age < 18;
        }
        static bool IsSenior(Person person)
        {
            return person.Age >= 65;
        }
    }
}
