using System.ComponentModel.DataAnnotations;

namespace ToDoApplication.Models
{
	public class ToDo
	{
        
        public DateTime CompletionDate { get; set; } = DateTime.MinValue;

		[Key]
		public string Title { get; set; } = String.Empty;

		[Required]
		public bool IsComplete { get; set; } = false;
	}
}
