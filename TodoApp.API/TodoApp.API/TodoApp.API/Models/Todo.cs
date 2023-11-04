namespace TodoApp.API.Models
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }   
        public DateTime CreatedDate { get; set; }
        public bool Iscompleted { get; set;}
        public DateTime? CompletedDate { get; set; }
    }
}
