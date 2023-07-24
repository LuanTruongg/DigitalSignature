using DigitalSignature.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalSignature.Data.Configuration
{
	public class FormConfig : IEntityTypeConfiguration<Form>
	{
		public void Configure(EntityTypeBuilder<Form> builder)
		{
			builder.ToTable("Forms");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).IsRequired().HasMaxLength(450).ValueGeneratedOnAdd();
			builder.Property(x => x.Title).IsRequired().HasMaxLength(450);
			builder.Property(x => x.FileName).IsRequired().HasMaxLength(450);
			builder.Property(x => x.FilePath).IsRequired();
			builder.Property(x => x.CreateAt).IsRequired();
		}
	}
}
