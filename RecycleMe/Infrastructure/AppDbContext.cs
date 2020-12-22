using System.Diagnostics.CodeAnalysis;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
	public class AppDbContext : DbContext
	{
		public AppDbContext([NotNull] DbContextOptions options) : base(options)
		{
			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Answer>().HasOne(x=>x.ParentQuestion).WithMany(y=>y.Answers);
			modelBuilder.Entity<Answer>().HasOne(x => x.Material).WithOne(y => y.Answer).HasForeignKey<Material>(y => y.AnswerId);
			modelBuilder.Entity<Material>();
			modelBuilder.Entity<MaterialSubType>();
			modelBuilder.Entity<MaterialType>();
			modelBuilder.Entity<Property>();
			modelBuilder.Entity<Question>().HasOne(x=>x.ParentAnswer).WithOne(y=>y.ChildQuestion).HasForeignKey<Question>(y=>y.ParentAnswerId);
			modelBuilder.Entity<RecyclingFactory>();
			modelBuilder.Entity<RecyclingPoint>();
		}
	}
}
