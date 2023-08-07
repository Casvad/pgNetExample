using WebApplication15.Data;

namespace postgresExample.Repositories;

public class EmployeeRepository: IEmployeeRepository
{
    private readonly IDbRepository _dbRepository;

    public EmployeeRepository(IDbRepository dbRepository)
    {
        _dbRepository = dbRepository;
    }

    public async Task<bool> CreateEmployee(Employee employee)
    {
        
        var result =
            await _dbRepository.EditData(
                "INSERT INTO \"Employees\" (\"Id\",\"Name\", \"Age\", \"Address\", \"MobileNumber\", \"Title\") VALUES (@Id, @Name, @Age, @Address, @MobileNumber, @Title)",
                employee);
        return true;
    }

    public async Task<List<Employee>> GetEmployeeList()
    {
        
        var employeeList = await _dbRepository.GetAll<Employee>("SELECT * FROM \"Employees\" ", new { });
        return employeeList;
    }
    
    public async Task<Employee> GetEmployee(int id)
    {
        var employeeList = await _dbRepository.GetAsync<Employee>("SELECT * FROM \"Employees\" where id=@id", new {id});
        return employeeList;
    }

    public async Task<Employee> UpdateEmployee(Employee employee)
    {
        
        await _dbRepository.EditData(
                "Update \"Employees\" SET name=@Name, age=@Age, address=@Address, mobile_number=@MobileNumber WHERE id=@Id",
                employee);
        return employee;
    }
    

    public async Task<bool> DeleteEmployee(int key)
    {
        
        await _dbRepository.EditData("DELETE FROM \"Employees\" WHERE id=@Id", new {key});
        return true;
    }
}