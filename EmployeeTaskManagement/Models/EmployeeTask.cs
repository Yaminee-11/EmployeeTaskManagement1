using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeTaskManagement.Models
{
    public class EmployeeTask
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public TaskStatus Status { get; set; } = TaskStatus.Pending;
        public string AssignedById { get; set; }

        [ForeignKey(nameof(AssignedById))]
        public ApplicationUser AssignedBy { get; set; }
        public string AssignedToId { get; set; }

        [ForeignKey(nameof(AssignedToId))]
        public ApplicationUser AssignedTo { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime DueDate { get; set; }
    }
}