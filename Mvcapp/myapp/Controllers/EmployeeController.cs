using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myapp.Models;

namespace myapp.Controllers;

public class EmployeeController : Controller
{
    private readonly MAppContext _dbcontext;

    public EmployeeController(MAppContext dbbcontext)
    {
        _dbcontext = dbbcontext;
    }

    
    public IActionResult GetEmployees()
    {
        List<Employee> list = _dbcontext.Employees.ToList();
        ViewData["allemps"] = list;
        return View();
    }

    [HttpGet]
    public IActionResult AddEmployee(){
        return View();
    }

    [HttpPost]
    public IActionResult Add(Employee empobj){
        _dbcontext.Employees.Add(empobj);
        _dbcontext.SaveChanges();
        return RedirectToAction("GetEmployees");
    }
    
    [HttpGet]
    public IActionResult Delete(Employee empobj){
        _dbcontext.Employees.Remove(empobj);
        _dbcontext.SaveChanges();
        return RedirectToAction("GetEmployees");
    }
}
