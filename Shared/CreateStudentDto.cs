namespace Data;

public class CreateStudentDto
{
    public string Name { get;}
    public string Programme { get; }

    public CreateStudentDto(string name, string programme)
    {
        Name = name;
        Programme = programme;

    }
}