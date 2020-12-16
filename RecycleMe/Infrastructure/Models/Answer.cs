namespace Infrastructure.Models
{
	public class Answer
	{
		public int Id { get; set; }
		public int ParentQuestionId { get; set; }
		public Question ParentQuestion { get; set; }
		public int? ChildQuestionId { get; set; }
		public Question ChildQuestion { get; set; }
		public int? MaterialId { get; set; }
		public Material Material { get; set; }
		public string Text { get; set; }
	}
}
