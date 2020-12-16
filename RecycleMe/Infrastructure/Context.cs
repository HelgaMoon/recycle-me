using System.Diagnostics.CodeAnalysis;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
	class Context : DbContext
	{
		public Context([NotNull] DbContextOptions options) : base(options)
		{
			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Answer>();
			modelBuilder.Entity<Material>();
			modelBuilder.Entity<MaterialSubType>();
			modelBuilder.Entity<MaterialType>();
			modelBuilder.Entity<Property>();
			modelBuilder.Entity<Question>();
			modelBuilder.Entity<RecyclingFactory>();
			modelBuilder.Entity<RecyclingPoint>();
		}
	}
}
