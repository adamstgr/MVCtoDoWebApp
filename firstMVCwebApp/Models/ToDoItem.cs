namespace firstMVCwebApp.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime? DoItemWhen {  get; set; }
        public bool Reminder { get; set; }

        public ToDoItem() 
        {
            Id = Guid.NewGuid();
        }
    }
}
