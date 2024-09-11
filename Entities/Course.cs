namespace EducationalSystem.Entities;

public abstract class Course
{
    protected Course(DateTime courseDate, string? name, string? courseId, double score)
    {
        
        Name = name;
        CourseId = courseId;
        Score = score;
        CourseDate = courseDate;
        Score = score;
    }

    public string? Name { get; private set; }
    public string? CourseId { get; private set; }
    public double Score { get; private set; }
    public DateTime  CourseDate { get; private set; }
    
}
