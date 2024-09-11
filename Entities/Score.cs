namespace EducationalSystem.Entities;

public class Score
{
    public double Average { get; private set; }
    private static Course? Course { get; set; }

    public string? CourseName { get; } = Course?.Name;
    public string? CourseId { get; } = Course?.CourseId;
    public double? CourseScore { get; } = Course?.Score;
}


