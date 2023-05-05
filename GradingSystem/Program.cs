namespace GradingSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student("James Staurt", 24);
            Student studentTwo = new Student("John Doe", 53);
            Student studentThree = new Student("Imade Peter", 92); 

            Teacher teacher = new Teacher("Mr. Banky", "mrbanky342@gmail.com");

            Course course = new Course();

            course.AddStudent(studentOne);
            course.AddStudent(studentTwo);
            course.AddStudent(studentThree); 

            teacher.AddGrade(studentOne, 98.8); 
            
            teacher.AddGrade(studentTwo, 97.2); 
            
            teacher.AddGrade(studentThree, 75.2); 

           var average = course.CalculateAverageGrade();
            Console.WriteLine(average);
        } 
    }
}