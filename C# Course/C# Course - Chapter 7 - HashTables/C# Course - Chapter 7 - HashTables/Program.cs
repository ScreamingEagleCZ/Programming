using System;
using System.Collections;

namespace C__Course___Chapter_7___HashTables
{
    internal class Program
    {
        // Key - Value
        // Auto - Car

        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();
            Hashtable studentsChallenge = new Hashtable();
            Student[] students = new Student[6];

            Student stud1 = new Student(1, "Jeepers", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Freddie", 43);
            Student stud4 = new Student(4, "Chucky", 55);
            Student stud5 = new Student(1, "Jenna", 35);
            Student stud6 = new Student(6, "Jameson", 99);
            students[0] = stud1;
            students[1] = stud2;
            students[2] = stud3;
            students[3] = stud4;
            students[4] = stud5;
            students[5] = stud6;
            

            studentsTable.Add(stud1.Id, stud1 );
            studentsTable.Add(stud2.Id, stud2 );
            studentsTable.Add(stud3.Id, stud3 );
            studentsTable.Add(stud4.Id, stud4 );



            // Retrieve individual item with known ID
            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            // retrieve all values from Hashtable
            foreach (DictionaryEntry entry in studentsTable) 
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine($"Student ID: {temp.Id}");
                Console.WriteLine($"Student name: {temp.Name}");
                Console.WriteLine($"Student GPA: {temp.GPA}");
            }
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine($"Student ID: {value.Id}");
                Console.WriteLine($"Student name: {value.Name}");
                Console.WriteLine($"Student GPA: {value.GPA}");
            }
            foreach (Student s in students)
            {
                if (!studentsChallenge.ContainsKey(s.Id))
                {
                    studentsChallenge.Add(s.Id, s);
                    Console.WriteLine($"Added Student Id: {s.Id}, Name: {s.Name} and GPA: {s.GPA}");
                } else
                {
                    Console.WriteLine($"Sorry, student with this ID already exists... ID: {storedStudent1.Id}");
                }
            }

            Console.WriteLine($"Student ID: {storedStudent1.Id}, Name: {storedStudent1.Name}, GPA: {storedStudent1.GPA}");
        }
    }
}
