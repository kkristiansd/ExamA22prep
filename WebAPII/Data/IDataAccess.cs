using Data;

namespace WebAPII.Data;

public interface IDataAccess
{
    Task<Student> CreateStudentAsync(Student student);
    Task<ICollection<Student>> GetAllStudentsAsync();
    
    public Task AddGradeToStudentAsync(GradeInCourse grade,GradeInCourse studentId);
    Task<StatisticsOverviewDto?> GetCourseStatisticsAsync();

}