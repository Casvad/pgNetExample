using WebApplication15.Data;

namespace postgresExample.Repositories;

public interface IEmployeeRepository
{
    Task<bool> CreateEmployee(Employee employee);
    Task<List<Employee>> GetEmployeeList();
    Task<Employee> UpdateEmployee(Employee employee);
    Task<bool> DeleteEmployee(int key);

    Task<Employee> GetEmployee(int id);
}