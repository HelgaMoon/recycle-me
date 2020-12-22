using System.Collections.Generic;

namespace Infrastructure.Models
{
	public class RecyclingFactory
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<RecyclingPoint> RecyclingPoints { get; set; }
		public List<Material> Materials { get; set; }
	}
}
