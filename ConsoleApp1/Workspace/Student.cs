namespace ConsoleApp1.Exam
{
    public class Student
    {
        public string? StudentName { get; }
        public List<Course> Courses { get; set; }

        public Student(string? name)
        {
            StudentName = name;
            Courses = new List<Course>();
        }

        public void Enroll(Course course)
        {
            // Exclude "OOP" globally by not adding it to the course list
            if (course.CourseName != "OOP")
            {
                Courses.Add(course);
            }
            else
            {
                Console.WriteLine($"Cannot enroll in {course.CourseName}. This course is not available.");
            }
        }

        public void ShowCourses()
        {
            Console.WriteLine($"{StudentName} is enrolled in the following courses:");
            foreach (var course in Courses)
            {
                Console.WriteLine($"- {course.CourseName}");
            }
        }
    }

    // Association (Student - Course)
    public class Course
    {
        public Course(string? name)
        {
            CourseName = name;
        }
        public string CourseName { get; }
    }
}