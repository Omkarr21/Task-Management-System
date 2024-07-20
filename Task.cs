public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public ICollection<Note> Notes { get; set; }
    public ICollection<Document> Documents { get; set; }
}