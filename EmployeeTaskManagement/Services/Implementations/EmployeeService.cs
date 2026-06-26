using EmployeeTaskManagement.Models;
using EmployeeTaskManagement.Repositories.Interfaces;
using EmployeeTaskManagement.Services.Interfaces;

namespace EmployeeTaskManagement.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllEmployeesAsync()
        {
            return await _employeeRepository.GetAllEmployeesAsync();
        }

        public async Task<ApplicationUser?> GetEmployeeByIdAsync(string id)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(id);
        }

        public async Task UpdateEmployeeAsync(ApplicationUser employee)
        {
            await _employeeRepository.UpdateEmployeeAsync(employee);
        }
    }
}