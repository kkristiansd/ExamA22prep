using Data;
using Microsoft.AspNetCore.Mvc;
using WebAPII.Data;

namespace WebAPII.Controllers;
[ApiController]
[Route("[controller]")]

public class StudentController:ControllerBase
{
    private readonly IDataAccess dataLogic;

    public StudentController(IDataAccess dataLogic)
    {
        this.dataLogic = dataLogic;
    }
   
    
        [HttpPost, Route("CreateStudent")]
        public async Task<ActionResult> CreateStudent([FromBody] Student student)
        {
            try
            {
                Console.WriteLine("gay");
                await dataLogic.CreateStudentAsync(student);
               
                return Created($"/CreateStudent/{student.Name}", student);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    // Access the inner exception and handle it accordingly
                    var innerException = ex.InnerException;
                    // Log or display inner exception details
                }
        
                // Return an appropriate error response
                return StatusCode(500, "An error occurred while saving the entity changes.");
            }

        }
        
}