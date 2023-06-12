using System.ComponentModel.DataAnnotations;

namespace Data;

public class GradeInCourse
{
    [Key]
    [Required(ErrorMessage = "Course code is required.")]
    [MaxLength(4,ErrorMessage = "Invalid code")]
    public string CourseCode { get; set; }
    
    [Required(ErrorMessage = "Grade is required")]
    public int Grade { get; set; }
    
    public int studentId { get; }

    public Student Student { get; set; }
    
}