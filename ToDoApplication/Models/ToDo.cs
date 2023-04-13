using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ToDoApplication.Models
{
	public class ToDo
	{
		public int Id { get; set; }

		public DateTime CompletionDate { get; set; } = DateTime.MinValue;

		public string Title { get; set; } = String.Empty;

		public string Description { get; set; } = String.Empty;

		public bool IsComplete { get; set; } = false;
	}
}

