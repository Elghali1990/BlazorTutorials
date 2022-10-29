
using Infrastructer.Models;
using System.Collections;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlazorTutorials.Services
{
    public class EmployeService : IEmployee
    {
        private readonly HttpClient _http;
        public EmployeService(HttpClient http)
        {
            _http = http;
        }

        public async Task AddEmployee(Employee employee)
        {
            await _http.PostAsJsonAsync("https://localhost:7173/api/Employee/create", employee);
        }

        public async Task DeleteEmployee(Employee employee)
        {
            await _http.DeleteAsync("https://localhost:7218/api/User/deleteUser?id=" + employee.Id);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _http.GetFromJsonAsync<Employee[]>("https://localhost:7173/api/Employee/getAllEmployees");
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _http.GetFromJsonAsync<Employee>("https://localhost:7173/api/Employee/getEmployeesById/"+id);
        }

        public async Task UpdateEmployee(int id ,Employee employee)
        {
            await _http.PutAsJsonAsync("https://localhost:7173/api/Employee/update/"+id, employee);
        }
    }
}
