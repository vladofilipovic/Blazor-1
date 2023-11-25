// 03Students.Models.Student.cs

using System.Collections.Generic;

namespace _03Students.Models
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public string Major { get; set; }
        public List<Grade> Grades { get; set; } = new List<Grade>();
    }
}
