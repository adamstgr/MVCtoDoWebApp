using System.ComponentModel.DataAnnotations;

namespace firstMVCwebApp.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DoItemWhenDate { get; set; }
        [DataType(DataType.Time)]
        public DateTime? DoItemWhenTime { get; set; } 
        public bool Reminder { get; set; }

        public ToDoItem() 
        {
            Id = Guid.NewGuid();
        }
    }
}
