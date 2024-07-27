namespace C__Course_Chapter_7___Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Course Chapter 7 - Dictionary
            // key - value
            // auto - car
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()    // Example dictionary
            {
                {1, "one" },
                {2, "two"},
                {3, "three" }
            };
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Gwyn", 32, 21),
                new Employee("Secretary", "Nikky", 28, 18),
                new Employee("Lead Developer", "Artorias", 55, 35),
                new Employee("Intern", "Ernest", 22, 8)
            };
            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees) 
            {
                employeeDirectory.Add(emp.Role, emp);
            }
            string key = "Manager";
            // Testing if key exists in dictionary version 1 - using dictionary.ContainsKey(key)
            if (employeeDirectory.ContainsKey(key))
            {
                Employee empl = employeeDirectory[key];
                Console.WriteLine($"Employee Name: {empl.Name}, Role: {empl.Role}, Age: {empl.Age}, Rate: {empl.Rate}, Salary: {empl.Salary}.");
            } else
            {
                Console.WriteLine($"Sadly the {key} doesnt exists in dictionary.");
            }
            Delimitter();
            // Testing if key exists in dictionary version 2 - using dictionary.TryGetValue
            key = "HR";
            Employee result = null;
            if (employeeDirectory.TryGetValue(key, out result))
            {
                Console.WriteLine("Entry found!");
                Console.WriteLine($"Employee Name: {result.Name}");
                Console.WriteLine($"Role: {result.Role}");
                Console.WriteLine($"Age: {result.Age}");
                Console.WriteLine($"Salary: {result.Salary}");
            } else
            {
                Console.WriteLine($"Requested key \"{key}\" - cannot be found...");
            }
            // Update values in dictionary
            string keyToUpdate = "HR";
            if (employeeDirectory.ContainsKey(keyToUpdate))
            { 
                employeeDirectory[keyToUpdate] = new Employee("HR", "Jenna", 18, 300);
            } else { 
                Console.WriteLine($"Sorry key \"{keyToUpdate}\" does not exists..."); 
            }
            // Delete entry in dictionary
            string keyToRemove = "Manager";
            if (employeeDirectory.ContainsKey(keyToRemove))
            { 
                employeeDirectory.Remove(keyToRemove); 
            } else { 
                Console.WriteLine($"Sorry key \"{keyToRemove}\" does not exists...");
            }
            Delimitter();
            // Usint ElementAt(i) to return key-value pair stored at index i (key indexes has also int values like in arrays)
            for (int i = 0; i < employeeDirectory.Count; i++) 
            {
                KeyValuePair<string, Employee> keyValuePair = employeeDirectory.ElementAt(i);
                // Print the key
                Console.WriteLine($"Key: {keyValuePair.Key}");
                // Storing value in Employee object
                Employee employeeValue = keyValuePair.Value;
                // Printing the properties of employee object
                Console.WriteLine($"Employee Name: {employeeValue.Name}");
                Console.WriteLine($"Role: {employeeValue.Role}");
                Console.WriteLine($"Age: {employeeValue.Age}");
                Console.WriteLine($"Salary: {employeeValue.Salary}");
            }
            Delimitter();

        }
        static void Delimitter()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine();
        }
    }
    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        public Employee(string role, string name, int age, float rate) 
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
