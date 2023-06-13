using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Data;

namespace Blazor_Server.Data;

public class StudentHttpClient:IStudentService
{
    private readonly HttpClient client;

    public StudentHttpClient(HttpClient client)
    {
        this.client = client;
    }
    
    public async Task<Student> CreateAsync(CreateStudentDto dto)
    {
        
        HttpResponseMessage response = await client.PostAsJsonAsync("/Students/CreateStudent", dto);
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }

        Student student = JsonSerializer.Deserialize<Student>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return student;
    }

    public Task<ICollection<Student>> GetAllStudentsAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddGradeToStudentAsync(GradeInCourse grade, int studentId)
    {
        throw new NotImplementedException();
    }
}