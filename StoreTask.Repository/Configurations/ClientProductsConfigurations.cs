using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StoreTask.Core.Models;

namespace StoreTask.Repository.Configurations
{
    public class ClientProductsConfigurations : IEntityTypeConfiguration<ClientProducts>
    {
        public void Configure(EntityTypeBuilder<ClientProducts> builder)
        {
            builder.Property(cp => cp.StartDate)
            .IsRequired();

            // Configure the EndDate as optional
            builder.Property(cp => cp.EndDate)
                .IsRequired(false);

            // Configure the License property with a max length of 255
            builder.Property(cp => cp.License)
                .IsRequired()
                .HasMaxLength(255);


        }
    }
}
