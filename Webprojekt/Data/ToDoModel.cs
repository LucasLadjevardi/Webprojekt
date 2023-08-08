using System.ComponentModel.DataAnnotations;

namespace Webprojekt.Data
{
    public class ToDoModel
    {
        [Key]
        public int ToDoID { get; set; }
        public string Titel { get; set; }
        public string Beskrivelse { get; set; }
        public DateTime Dato { get; set; }
        public Guid UserID { get; set; }
    }
}