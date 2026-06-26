using EmployeeTaskManagement.Models;

namespace EmployeeTaskManagement.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<ApplicationUser>> GetAllEmployeesAsync();

        Task<ApplicationUser?> GetEmployeeByIdAsync(string id);

        Task<ApplicationUser?> GetEmployeeByEmailAsync(string email);

        Task<bool> EmployeeExistsAsync(string email);

        Task UpdateEmployeeAsync(ApplicationUser employee);
    }
}