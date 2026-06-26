using EmployeeTaskManagement.Models;

namespace EmployeeTaskManagement.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<ApplicationUser>> GetAllEmployeesAsync();

        Task<ApplicationUser?> GetEmployeeByIdAsync(string id);

        Task UpdateEmployeeAsync(ApplicationUser employee);
    }
}