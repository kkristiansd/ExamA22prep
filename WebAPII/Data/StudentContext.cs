namespace WebAPII.Data;

public class StudentContext:DbContext
{
    public DbSet<Student> Students { get; set; }
}