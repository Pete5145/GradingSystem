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
            IList<double> courseGrades = new List<double>();

            foreach (var student in students)
            { 
                for (int i = 0; i < student.Grades.Count; i++)
                {
                    courseGrades.Add(student.Grades[i]);
                } 
            }

            double sum = 0;
            
            for (int i = 0; i < courseGrades.Count; i++)
            {
                sum += courseGrades[i];
            }

            double average = sum/ courseGrades.Count;
            return average;
        }
    }
}
