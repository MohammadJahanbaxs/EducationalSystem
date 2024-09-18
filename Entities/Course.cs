namespace EducationalSystem.Entities;

public class Course
{
    
    public string? Name { get; private set; }
    public string? CourseId { get; private set; }
    public double Score { get; private set; }
    public bool Accepted { get; private set; }
    public DateTime  CourseDate { get; private set; }
    
}
