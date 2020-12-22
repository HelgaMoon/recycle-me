using System.Collections.Generic;

namespace Infrastructure.Models
{
	public class RecyclingPoint
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<RecyclingFactory> RecyclingFactories {get;set;}
		public List<Material> Materials { get; set; }
	}
}
