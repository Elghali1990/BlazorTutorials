
using Infrastructer.Models;
using System.Collections;

namespace Infrastructer.Interfaces
{
    public interface IEmployee
    {
        List<Employee> GetAllEmployees();
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        Employee GetEmployeeById(int id);
        void DeleteEmployee(Employee employee);
    }
}
