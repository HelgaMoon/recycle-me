using System.Collections.Generic;

namespace Infrastructure.Models
{
	public class MaterialSubType
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public List<Material> Materials { get; set; }
		public List<Property> Properties { get; set; }

	}
}
