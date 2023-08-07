using Microsoft.AspNetCore.Mvc;
using postgresExample.Repositories;
using WebApplication15.Data;

namespace postgresExample.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeesController : Controller
{
    private readonly IEmployeeRepository _employeeRepository;
    
    public EmployeesController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result =  await _employeeRepository.GetEmployeeList();

        return Ok(result);
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetEmployee(int id)
    {
        var result =  await _employeeRepository.GetEmployee(id);

        return Ok(result);
    }
    
    [HttpPost]
    public async Task<IActionResult> AddEmployee([FromBody]Employee employee)
    {
        var result =  await _employeeRepository.CreateEmployee(employee);

        return Ok(result);
    }
    
    [HttpPut]
    public async Task<IActionResult> UpdateEmployee([FromBody]Employee employee)
    {
        var result =  await _employeeRepository.UpdateEmployee(employee);

        return Ok(result);
    }
    
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        var result =  await _employeeRepository.DeleteEmployee(id);

        return Ok(result);
    }
}