using Data;

namespace Blazor_Server.Data;

public interface IStudentService
{
    Task<Student> CreateAsync(CreateStudentDto dto);
    Task<ICollection<Student>> GetAllStudentsAsync();
    public Task AddGradeToStudentAsync(GradeInCourse grade, int studentId);
}