namespace Module2Review;

public class Course
{
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    private List<Student> EnrolledStudents;

    public Course()
    {
        EnrolledStudents = new List<Student>();
    }

    public void EnrollStudent(Student student)
    {
        if (!EnrolledStudents.Exists(s => s.ID == student.ID))
        {
            EnrolledStudents.Add(student);
        }
        else
        {
            Console.WriteLine($"Student {student.Name} is already enrolled in {CourseName}.");
        }
    }

    public void DisplayCourseInfo()
    {
        Console.WriteLine($"\nCourse: {CourseName} ({CourseCode})");
        Console.WriteLine("Enrolled Students:");
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine($"- {student.Name} (ID: {student.ID})");
        }
    }
}

