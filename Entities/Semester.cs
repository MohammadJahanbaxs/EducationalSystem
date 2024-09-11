namespace EducationalSystem.Entities;

public class Semester
{
    public Semester(DateTime semesterDate, int units, string semId, Course? course)
    {
        SemesterDate = semesterDate;
        Units = units;
        SemId = semId;
        Course = course;
    }
    
    public DateTime SemesterDate { get; private set; }
    public int Units { get; private set; }
    public string SemId { get; private set; }
    private static Course? Course { get; set; }
    
    public string? CourseName { get; } = Course?.Name;
    public string? CourseId { get; } = Course?.CourseId;
    public double? CourseScore { get; } = Course?.Score;
    public enum Season
    {
        Spring,
        Summer,
        Autumn   // پاییز                
    }
    
}