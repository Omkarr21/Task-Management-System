public interface ITaskRepository
{
    Task<IEnumerable<Task>> GetAllTasksAsync();
    Task<Task> GetTaskByIdAsync(int id);
    Task AddTaskAsync(Task task);
    Task UpdateTaskAsync(Task task);
    Task DeleteTaskAsync(int id);
}
