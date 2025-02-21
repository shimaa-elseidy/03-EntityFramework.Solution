using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demo
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(100, 100);
            builder.Property(x => x.Name).HasColumnName("DeptName").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.CreateAt).IsRequired(); 
        }
    }
}
