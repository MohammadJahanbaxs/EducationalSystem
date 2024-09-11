namespace EducationalSystem.Entities;

public class Student
{
    
    public string StudentId { get; private set; }
    public string Name { get; private set; }
    public string NationalCode { get; private set; }
    private string Password { get; set; }
    public double Gpa { get; private set; } //Gpa : Grade point average
    private List<Course> WeeklySchedule { get; set; }
    
    public void AddCourse(Course course)
    {
        WeeklySchedule.Add(course);
    }
    
    public void ShowCourse()
    {
        foreach (var course in WeeklySchedule)
        {
            Console.WriteLine($"Course: {course.Name}, ID: {course.CourseId}");
        }
    }
    
    public enum Degree
    {
        Bachelor,
        Master,
        PhD
    }
}