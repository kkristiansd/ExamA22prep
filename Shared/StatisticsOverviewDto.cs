namespace Data;

public class StatisticsOverviewDto
{
    public string CourseCode { get; set; }
    
    public int? TotalNumOfPassedStudents { get; private set; }
    
    public int? TotalNumOfStudents { get; private set; }
    
    public float? AvgGradeOverall { get; private set; }
    
    public float? AvgGradeOfPassed { get; private set; }
    
    public int? MedianGrade { get; private set; }
    
    
    
}