namespace EducationalSystem.Entities;

public class Teacher
{
    public Teacher(string teacherId, string name, string nationalCode, string password, double salary, double grant, Course? course)
    {
        TeacherId = teacherId;
        Name = name;
        NationalCode = nationalCode;
        Password = password;
        Salary = salary;
        Grant = grant;
        Course = course;
    }

    public string TeacherId { get; private set; }
    public string Name { get; private set; }
    public string NationalCode { get; private set; }
    private string Password { get; set; }
    public double Salary { get; private set; }
    public double Grant { get; private set; }
    private static Course? Course { get; set; }
    
    public string? CourseName { get; } = Course?.Name;
    public string? CourseId { get; } = Course?.CourseId;
    public double? CourseScore { get; } = Course?.Score;
    
    public enum Degree
    {
        Coach,
        AssistantProfessor,
        AssociateProfessor,
        FullProfessor
    }
}