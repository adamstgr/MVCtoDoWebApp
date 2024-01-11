namespace firstMVCwebApp.Models
{
    public class ToDo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ToDo() 
        {
            Id = Guid.NewGuid();
        }
    }
}
