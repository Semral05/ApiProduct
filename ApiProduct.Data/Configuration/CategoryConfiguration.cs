using ApiProduct.Core.Models.BaseModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProduct.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(30)
                .IsRequired();
            builder.Property(x => x.CreatedAt)
                .HasDefaultValue(DateTime.Now.AddHours(4))
                .IsRequired();
        }
    }
}
