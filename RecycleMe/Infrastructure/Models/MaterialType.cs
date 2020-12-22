using System.Collections.Generic;

namespace Infrastructure.Models
{
	public class MaterialType
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public List<MaterialSubType> MaterialSubTypes { get; set; }
	}
}
