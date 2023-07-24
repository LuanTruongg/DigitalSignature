using DigitalSignature.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Data.Configuration
{
	public class DocumentHistoryConfig : IEntityTypeConfiguration<DocumentHistory>
	{
		public void Configure(EntityTypeBuilder<DocumentHistory> builder)
		{
			builder.ToTable("DocumentHistories");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
			builder.Property(x => x.TimeStamp).IsRequired().HasMaxLength(450);
			builder.Property(x => x.CreateAt).IsRequired();

			builder.HasOne(x => x.Document).WithMany(x => x.DocumentHistories).HasForeignKey(x=> x.DocumentId);
			builder.HasOne(x => x.Signature).WithMany(x => x.DocumentHistories).HasForeignKey(x => x.SignatureId);
			builder.HasOne(x => x.User).WithMany(x => x.DocumentHistories).HasForeignKey(x => x.UserId);
		}
	}
}
