using DigitalSignature.Data.Configuration;
using DigitalSignature.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Data.EF
{
	public class DigitalSignatureDbContext : IdentityDbContext<AppUser>
	{
        public DigitalSignatureDbContext(DbContextOptions<DigitalSignatureDbContext> options) :base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfiguration(new FormConfig());
			modelBuilder.ApplyConfiguration(new AppUserConfig());
			modelBuilder.ApplyConfiguration(new DocumentConfig());
			modelBuilder.ApplyConfiguration(new DocumentHistoryConfig());
			modelBuilder.ApplyConfiguration(new SignatureConfig());
		}
		#region
		public DbSet<Form> Forms { get; set; }
		#endregion
		#region
		public DbSet<Department> Departments { get; set; }
		#endregion
		#region
		public DbSet<Document> Documents { get; set; }
		#endregion
		#region
		public DbSet<DocumentHistory> DocumentHistories { get; set; }
		#endregion
		#region
		public DbSet<Entities.Signature> Signatures { get; set; }
		#endregion
	}
}
