using DigitalSignature.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalSignature.Data.Configuration
{
	public class DocumentConfig : IEntityTypeConfiguration<Document>
	{
		public void Configure(EntityTypeBuilder<Document> builder)
		{
			builder.ToTable("Documents");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).IsRequired().HasMaxLength(450).ValueGeneratedOnAdd();
			builder.Property(x => x.Title).IsRequired();
			builder.Property(x => x.FilePath).IsRequired();
			builder.Property(x => x.CreateAt).IsRequired();
			builder.Property(x => x.UpdateAt).IsRequired();

			//builder.HasOne(x => x.DocumentHistory).WithOne(x => x.Document);
		}
	}
}
