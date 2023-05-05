using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Course> Courses { get; set; }

        public Teacher(string name, string email)
        {
            Name = name;
            Email = email;
            Courses = new List<Course>();
        }
        public void AddGrade(Student student, double grade) 
        {
            student.Grades.Add(grade);
            foreach (Course course in Courses)
            {
                if (!course.students.Contains(student))
                {
                    Console.WriteLine($"{student.Name} is not enrolled.");
                }
            }
        }   
    }
}
