using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pustok.Core.Entities;

namespace Pustok.DataAccess.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Name)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(e => e.Surname)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(e => e.Email)
               .IsRequired()
               .HasMaxLength(150);

        builder.Property(e => e.PhoneNumber)
               .HasMaxLength(20);

        builder.Property(e => e.Salary)
               .HasColumnType("decimal(18,2)");

        builder.Property(e => e.IsActive)
               .HasDefaultValue(true);

        builder.HasOne(e => e.Department)
               .WithMany(d => d.Employees)
               .HasForeignKey(e => e.DepartmentId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
