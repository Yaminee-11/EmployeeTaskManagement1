using EmployeeTaskManagement.Models;

namespace EmployeeTaskManagement.Services.Interfaces
{
    public interface ITaskService
    {
        Task<IEnumerable<EmployeeTask>> GetAllTasksAsync();

        Task<EmployeeTask?> GetTaskByIdAsync(int id);

        Task<IEnumerable<EmployeeTask>> GetTasksByEmployeeIdAsync(string employeeId);

        Task AddTaskAsync(EmployeeTask task);

        Task UpdateTaskAsync(EmployeeTask task);

        Task DeleteTaskAsync(EmployeeTask task);
    }
}