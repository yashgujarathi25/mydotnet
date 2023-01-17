using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myapp.Models;

namespace myapp.Controllers;

public class EmployeeController : Controller
{
    private readonly MVCAppContext _dbContext;

    public EmployeeController(MVCAppContext dbContext)
    {
        _dbContext = dbContext;
    }

    protected override void Dispose(bool disposing)
    {
        _dbContext.Dispose();
    }
    
    [HttpGet]
    public IActionResult GetEmployees(){
        List<Employee> list = _dbContext.Employees.ToList();
        ViewData["allemps"] = list;
        return View();
    }

    
}
