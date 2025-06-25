using System;

namespace Module2Review
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            
            Course courseOne = new Course
            {
                CourseName = "History",
                CourseCode = "H1"
            };
            Course courseTwo = new Course()
            {
                CourseName = "Art",
                CourseCode = "A"
            };

            // Using custom constructor
            Student studentOne = new Student("Kayla", 101);
            // Using object initializer syntax
            Student studentTwo = new Student("Jasper", 102);
            Student studentThree = new Student("Alex", 103); //{ Grades = new List<double>() };
            // Using dot notation after default constructor
            Student studentFour = new Student("Ava", 104);
            
            courseOne.EnrollStudent(studentOne);
            courseOne.EnrollStudent(studentTwo);
            courseOne.EnrollStudent(studentThree);
            courseOne.EnrollStudent(studentFour);
            
            courseOne.DisplayCourseInfo();
            courseTwo.EnrollStudent(studentOne);
            courseTwo.EnrollStudent(studentTwo);
            courseTwo.EnrollStudent(studentThree);
            courseTwo.EnrollStudent(studentFour);
            
            courseTwo.DisplayCourseInfo();


            // Add students to list
            students.Add(studentOne);
            students.Add(studentTwo);
            students.Add(studentThree);
            students.Add(studentFour);

            // Step 7: Call AddGrade overloads
            studentOne.AddGrade(98.9);
            studentOne.AddGrade(98.0, 76.3, 92.4);

            studentTwo.AddGrade(85.5);
            studentTwo.AddGrade(87.0, 91.2);

            studentThree.AddGrade(76.0);
            studentThree.AddGrade(80.5, 75.3);

            studentFour.AddGrade(89.5);
            studentFour.AddGrade(92.1, 87.4);

            // Step 8: Display each student's info
            foreach (Student student in students)
            {
                Console.WriteLine($"\nID: {student.ID}, Name: {student.Name}");
                Console.Write("Grades: ");
                foreach (double grade in student.Grades)
                {
                    Console.Write($"{grade} ");
                }

                Console.WriteLine($"\nAverage Grade: {student.CalculateAverageGrade():F2}");
            }
        }
    }
}

//testing
