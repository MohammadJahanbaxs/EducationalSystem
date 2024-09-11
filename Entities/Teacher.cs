namespace EducationalSystem.Entities;

public class Teacher
{
    
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