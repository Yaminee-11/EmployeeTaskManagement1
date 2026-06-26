using EmployeeTaskManagement.Models;
using EmployeeTaskManagement.Repositories.Interfaces;
using EmployeeTaskManagement.Services.Interfaces;

namespace EmployeeTaskManagement.Services.Implementations
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<IEnumerable<EmployeeTask>> GetAllTasksAsync()
        {
            return await _taskRepository.GetAllTasksAsync();
        }

        public async Task<EmployeeTask?> GetTaskByIdAsync(int id)
        {
            return await _taskRepository.GetTaskByIdAsync(id);
        }

        public async Task<IEnumerable<EmployeeTask>> GetTasksByEmployeeIdAsync(string employeeId)
        {
            return await _taskRepository.GetTasksByEmployeeIdAsync(employeeId);
        }

        public async Task AddTaskAsync(EmployeeTask task)
        {
            await _taskRepository.AddTaskAsync(task);
        }

        public async Task UpdateTaskAsync(EmployeeTask task)
        {
            await _taskRepository.UpdateTaskAsync(task);
        }

        public async Task DeleteTaskAsync(EmployeeTask task)
        {
            await _taskRepository.DeleteTaskAsync(task);
        }
    }
}