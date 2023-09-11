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
	public class DepartmentConfig : IEntityTypeConfiguration<Department>
	{
		public void Configure(EntityTypeBuilder<Department> builder)
		{
			builder.ToTable("Departments");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).IsRequired();

			//builder.HasOne(x => x.User).WithMany(x => x.).HasForeignKey(x => x.Id);
		}
	}
}
