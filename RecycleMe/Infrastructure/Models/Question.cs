using System.Collections.Generic;

namespace Infrastructure.Models
{
	public class Question
	{
		public int Id { get; set; }
		public int? ParentAnswerId { get; set; }
		public Answer ParentAnswer { get; set; }
		public List<Answer> Answers { get; set; }
		public string Text { get; set; }
	}
}
