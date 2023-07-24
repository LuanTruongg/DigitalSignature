
using DigitalSignature.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalSignature.Data.Configuration
{
	public class SignatureConfig : IEntityTypeConfiguration<Signature>
	{
		public void Configure(EntityTypeBuilder<Signature> builder)
		{
			builder.ToTable("Signatures");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).IsRequired().HasMaxLength(450).ValueGeneratedOnAdd();

			builder.Property(x => x.Description).HasMaxLength(450);

			//builder.HasOne(x => x.DocumentHistory).WithMany(x => x.Signature).HasForeignKey(x => x.Id);
		}
	}
}
