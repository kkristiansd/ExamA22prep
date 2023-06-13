using Data;
using Microsoft.EntityFrameworkCore;

namespace WebAPII.Data;

public class StudentContext:DbContext
{
    public DbSet<Student> Student { get; init; }
    public DbSet<GradeInCourse> Grade { get; set; } 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = ../WebAPII/Student.db");
    }

}