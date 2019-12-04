using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp1.Models;

namespace WebApp1.Data.Configuration {
    public class ProductConfiguration : IEntityTypeConfiguration<Product> {

        public void Configure (EntityTypeBuilder<Product> builder) {
            builder.Property(p => p.ImageName).HasColumnName("ImageFileName");

        }

    }
}