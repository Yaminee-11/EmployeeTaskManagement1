using EmployeeTaskManagement.Data;
using EmployeeTaskManagement.Models;
using EmployeeTaskManagement.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeTaskManagement.Repositories.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllEmployeesAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<ApplicationUser?> GetEmployeeByIdAsync(string id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ApplicationUser?> GetEmployeeByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<bool> EmployeeExistsAsync(string email)
        {
            return await _context.Users.AnyAsync(x => x.Email == email);
        }

        public async Task UpdateEmployeeAsync(ApplicationUser employee)
        {
            _context.Users.Update(employee);

            await _context.SaveChangesAsync();
        }
    }
}