using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demo.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn(10,10);
            builder.Property(e => e.Name).HasColumnName("EmpName").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(e => e.Age).IsRequired();
            builder.Property(e => e.Salary).HasColumnType("money");
            builder.Property(e => e.Address).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(e => e.HiringDate);
            
            builder.HasOne(e => e.WorkFor).WithMany(d=>d.Employees).HasForeignKey(e=>e.DeptId);

        }
    }
}
