using Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace WebAPII.Data;

public class DataAccess:IDataAccess
{
    private readonly StudentContext context;

    public DataAccess(StudentContext context)
    {
        this.context = context;
    }
    
    public async Task<Student> CreateStudentAsync(Student student)
    {
        Student toCreate = new Student()
        {
            Name = student.Name,
            Programme = student.Programme,
            GradeInCourses = student.GradeInCourses,
        };

        EntityEntry<Student> newStudent = await context.Student.AddAsync(toCreate);
        await context.SaveChangesAsync();
        return newStudent.Entity;
    }

    public Task<ICollection<Student>> GetAllStudentsAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddGradeToStudentAsync(GradeInCourse grade, GradeInCourse studentId)
    {
        throw new NotImplementedException();
    }

    public Task<StatisticsOverviewDto?> GetCourseStatisticsAsync()
    {
        throw new NotImplementedException();
    }
}