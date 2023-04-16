using System.ComponentModel.DataAnnotations;

namespace ToDoApplication.Models
{
	public class ToDo
	{
		[Key]
		public int ID { get; set; }

        public DateTime? CompletionDate { get; set; }

        [Required]
        public string Title { get; set; } = String.Empty;

		[Required]
		public bool IsComplete { get; set; } = false;
	}
}
