using System.ComponentModel.DataAnnotations;

namespace Data;

public class Student
{
    [Key]
    public int studentId { get; set; }
    [Required(ErrorMessage = "Name is required!")]
    [StringLength(25,ErrorMessage = "Wrong name buddy.")]
    public string Name { get; set; }   
    [Required(ErrorMessage = "Programme is required!")]
    public string Programme { get; set; }
    
    
    

    public Student(string Name, string Programme)
    {
        this.Name = Name;
        this.Programme = Programme;
    }

    public Student()
    {
        
    }
}