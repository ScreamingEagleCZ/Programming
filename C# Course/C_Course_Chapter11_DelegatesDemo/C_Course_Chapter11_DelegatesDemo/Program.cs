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
            DisplayPeople("Adultos", people, IsAdult);
            DisplayPeople("Gerontos", people, IsSenior);

            // here is created a new variable called filter of type FilterDelegate.
            // it has assigned anonymous method to it instead of an already defined method
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };  // there has to be ";" at the end since its definition of variable and at the same time assigning it
            DisplayPeople("20 to 30", people, filter);  // usement of above anonymous method/variable "filter"

            // anonymous method - similar as above
            DisplayPeople("All: ", people, delegate (Person p) { return true; });

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
