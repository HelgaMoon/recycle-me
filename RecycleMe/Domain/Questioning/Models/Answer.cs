namespace Domain.Questioning.Models
{
	public class Answer
	{
		string text;
		int parentQuestionId;
		int? questionId;
		int? materialId;

		public string GetLink() => questionId == null ? $"material\\{materialId}" : $"question\\{questionId}";
	}
}
