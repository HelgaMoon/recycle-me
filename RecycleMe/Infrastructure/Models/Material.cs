using System.Collections.Generic;

namespace Infrastructure.Models
{
	public class Material
	{
		public int Id { get; set; }
		public string Image { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int AnswerId { get; set; }
		public Answer Answer { get; set; }
		public int MaterialSubTypeId { get; set; }
		public MaterialSubType MaterialSubType { get; set; }
		public int RecyclingPointId { get; set; }
		public RecyclingPoint RecyclingPoint { get; set; }
		public int RecyclingFactoryId { get; set; }
		public RecyclingFactory RecyclingFactory { get; set; }
		public List<Property> Properties { get; set; }
	}
}
