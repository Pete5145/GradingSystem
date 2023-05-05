using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    public class Course
    {
        public IList<Student> students { get; set; }

        public Course()
        {
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {    
            students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        public double CalculateAverageGrade() 
        {   
            double sum = 0;
            foreach (var student in students)
            { 
                for (int i = 0; i < student.Grades.Count; i++)
                {
                    sum += student.Grades[i];
                } 
            }

            double average = sum / students.Count;
            return average;
        }
    }
}