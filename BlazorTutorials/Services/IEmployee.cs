using Infrastructer.Models;
using System.Collections;

namespace BlazorTutorials.Services
{
    public interface IEmployee
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task AddEmployee(Employee employee);
        Task UpdateEmployee(int id ,Employee employee);
        Task<Employee> GetEmployeeById(int id);
        Task DeleteEmployee(Employee employee);
    }
}
