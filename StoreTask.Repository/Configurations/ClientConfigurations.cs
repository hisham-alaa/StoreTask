using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreTask.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreTask.Repository.Configurations
{
    public class ClientConfigurations : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {

            builder.Property(c => c.Code)
                .HasColumnType("varchar(9)")
                .IsRequired();

            builder.Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.State)
                .HasConversion(
                            cState => cState.ToString(),
                            cState => (ClientState)Enum.Parse(typeof(ClientState), cState));

            builder.Property(c => c.Class)
                .HasConversion(
                            cClass => cClass.ToString(),
                            cClass => (ClientClass)Enum.Parse(typeof(ClientClass), cClass));

        }
    }
}
