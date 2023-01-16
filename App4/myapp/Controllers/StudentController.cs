using Microsoft.AspNetCore.Mvc;
using myapp.Models;
namespace myapp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly DbTest4Context _dbContext;

    

    public StudentController(DbTest4Context dbContecxt)
    {
        _dbContext = dbContecxt;
    }

    [HttpGet]
    [Route("GetStudents")]
    
    public IActionResult Get(){
        List<Student> list = _dbContext.Students.ToList();
        return StatusCode(StatusCodes.Status200OK, list);
    }
}
