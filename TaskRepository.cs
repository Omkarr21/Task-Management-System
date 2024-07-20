public class TaskRepository : ITaskRepository
{
    private readonly AppDbContext _context;

    public TaskRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Task>> GetAllTasksAsync()
    {
        return await _context.Tasks.Include(t => t.Employee).ToListAsync();
    }

    public async Task<Task> GetTaskByIdAsync(int id)
    {
        return await _context.Tasks.Include(t => t.Employee).FirstOrDefaultAsync(t => t.Id == id);
    }
 public async Task AddTaskAsync(Task task)
    {
        await _context.Tasks.AddAsync(task);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateTaskAsync(Task task)
    {
        _context.Tasks.Update(task);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTaskAsync(int id)
    {
        var task = await _context.Tasks.FindAsync(id);
        if (task != null)
        {
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
        }
    }
}
