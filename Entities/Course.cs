namespace EducationalSystem.Entities;

public abstract class Course
{
    
    public string? Name { get; private set; }
    public string? CourseId { get; private set; }
    public double Score { get; private set; }
    public DateTime  CourseDate { get; private set; }
    
}
