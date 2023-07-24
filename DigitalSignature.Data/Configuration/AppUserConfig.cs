using DigitalSignature.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalSignature.Data.Configuration
{
	public class AppUserConfig : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder.ToTable("AppUsers");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).IsRequired().HasMaxLength(450).ValueGeneratedOnAdd();
			builder.Property(x => x.FirstName).IsRequired().HasMaxLength(250);
			builder.Property(x => x.LastName).IsRequired().HasMaxLength(250);
			builder.Property(x => x.CIC).IsRequired().HasMaxLength(250);
			builder.Property(x => x.CreateAt).IsRequired();
			builder.Property(x => x.UpdateAt).IsRequired();
			builder.Property(x => x.CreateBy).IsRequired().HasMaxLength(250);
			builder.Property(x => x.UpdateBy).IsRequired().HasMaxLength(250);

			builder.HasOne(x => x.Department).WithOne(x => x.User);
		}
	}
}
