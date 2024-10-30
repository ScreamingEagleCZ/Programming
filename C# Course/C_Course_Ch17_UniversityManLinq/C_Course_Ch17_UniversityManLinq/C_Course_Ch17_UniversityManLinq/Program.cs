using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Ch17_UniversityManLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromBeijingTech();
            um.AllStudentsFromYale();

            int uniId = GetIntFromUser("Input Id of university for list of students (1-2): ");
            um.AllStudentsFromRequestedUniversity(uniId);
            um.StudentAndUniversityNameCollection();

            // sorting lists
            int[] someInts = { 30, 12, 4, 3, 12, 72, 8, 15, 34, 48, 52, };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i; // sorting in Linq
            IEnumerable<int> reverseSorting = sortedInts.Reverse();             // reversing list in Linq
            foreach (int i in reverseSorting)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> reversedSorting2 = from i in someInts orderby i descending select i;   // same as above but direct (shorter)
            foreach (int i in reversedSorting2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
        public static int GetIntFromUser(string prompt)
        {
            int value;
            string input;
            do
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out value));
            return value;
        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        // Constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            //filling Universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            //filling students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 6, Name = "Frank", Gender = "male", Age = 37, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male Students: ");
            foreach(Student student in maleStudents)
            {
                student.Print();
            }
        }
        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female Students: ");
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }
        public void SortStudentsByAge()
        {
            // var instead of IEnumerable<> is smart enough to know that IEnumerable should be used
            // but the code is slightly slower than explicitly defining list as Ienumerable
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Students sorted by age: ");
            foreach(Student student in sortedStudents)
            {
                student.Print();
            }
        }
        public void AllStudentsFromBeijingTech()
        {
            //joining 2 lists based on foreign key student.universityID
            IEnumerable<Student> bjtStudents = from student in students 
                                               join university in universities 
                                               on student.UniversityId equals university.Id
                                               where university.Name == "Beijing Tech"
                                               select student;
            Console.WriteLine("Students from Beijing Tech: ");
            foreach(Student student in  bjtStudents)
            {
                student.Print();
            }
        }
        public void AllStudentsFromYale()
        {
            //joining 2 lists based on foreign key student.universityID
            IEnumerable<Student> yaleStudents = from student in students
                                                join university in universities
                                                on student.UniversityId equals university.Id
                                                where university.Name == "Yale"
                                                select student;
            Console.WriteLine("Students from Yale: ");
            foreach (Student student in yaleStudents)
            {
                student.Print();
            }
        }
        public void AllStudentsFromRequestedUniversity(int uniId)
        {
            IEnumerable<Student> requestedUniversity = from student in students
                                                       join university in universities
                                                       on student.UniversityId equals university.Id
                                                       where university.Id == uniId
                                                       select student;
            Console.WriteLine($"All students from requested Id: {uniId} of university: ");
            foreach(Student student in requestedUniversity)
            {
                student.Print();
            }
        }
        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities
                                on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };
            Console.WriteLine("New Collection: ");
            foreach (var col in newCollection)
            {
                Console.WriteLine($"Student {col.StudentName} from University {col.UniversityName}");
            }
        }
    }
    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine($"University {Name} with Id: {Id}");
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //foreign key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine($"Student {Name} with id: {Id}, " +
                $"Gender: {Gender} and Age: {Age} from University with Id: {UniversityId}");
        }
    }
}
