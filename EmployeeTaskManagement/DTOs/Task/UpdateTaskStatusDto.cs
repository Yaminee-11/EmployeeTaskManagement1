namespace EmployeeTaskManagement.DTOs.Task
{
    public class UpdateTaskStatusDto
    {
        public int TaskId { get; set; }

        public string Status { get; set; } = string.Empty;
    }
}