using EmployeeTaskManagement.Data;
using EmployeeTaskManagement.Models;
using EmployeeTaskManagement.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeTaskManagement.Repositories.Implementations
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EmployeeTask>> GetAllTasksAsync()
        {
            return await _context.EmployeeTasks
                .Include(x => x.AssignedBy)
                .Include(x => x.AssignedTo)
                .ToListAsync();
        }

        public async Task<EmployeeTask?> GetTaskByIdAsync(int id)
        {
            return await _context.EmployeeTasks
                .Include(x => x.AssignedBy)
                .Include(x => x.AssignedTo)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<EmployeeTask>> GetTasksByEmployeeIdAsync(string employeeId)
        {
            return await _context.EmployeeTasks
                .Where(x => x.AssignedToId == employeeId)
                .Include(x => x.AssignedBy)
                .ToListAsync();
        }

        public async Task AddTaskAsync(EmployeeTask task)
        {
            await _context.EmployeeTasks.AddAsync(task);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateTaskAsync(EmployeeTask task)
        {
            _context.EmployeeTasks.Update(task);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(EmployeeTask task)
        {
            _context.EmployeeTasks.Remove(task);

            await _context.SaveChangesAsync();
        }
    }
}