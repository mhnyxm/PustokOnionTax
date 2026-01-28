using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pustok.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pustok.DataAccess.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable("Departments");

        builder.HasKey(d => d.Id);

        builder.Property(d => d.Name)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(d => d.Description)
               .HasMaxLength(500);

        builder.Property(d => d.CreatedAt)
               .HasDefaultValueSql("GETDATE()");

        builder.Property(d => d.IsActive)
               .HasDefaultValue(true);
    }
}
