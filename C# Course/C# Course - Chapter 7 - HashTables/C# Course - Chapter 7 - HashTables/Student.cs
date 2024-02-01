using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Course___Chapter_7___HashTables
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public float GPA { get; set;}

        public Student(int id, string name, float GPA) 
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
