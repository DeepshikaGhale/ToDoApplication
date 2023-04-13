using System.ComponentModel.DataAnnotations;

namespace ToDoApplication.Models
{
	public class ToDo
	{
		[Key]
		public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CompletionDate { get; set; } = DateTime.MinValue;

		[Required]
		public string Title { get; set; } = String.Empty;


		public string Description { get; set; } = String.Empty;

		[Required]
		public bool IsComplete { get; set; } = false;
	}
}
