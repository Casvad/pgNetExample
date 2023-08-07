using Dapper.Contrib.Extensions;

namespace WebApplication15.Data;

[Table("Employees")]
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string MobileNumber { get; set; }
}