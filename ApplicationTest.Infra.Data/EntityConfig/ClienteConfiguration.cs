using System.Data.Entity.ModelConfiguration;
using ApplicationTest.Domain.Entities;

namespace ApplicationTest.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteID);
            Property(c => c.Nome).IsRequired().HasMaxLength(50);
            Property(c => c.Sobrenome).IsRequired().HasMaxLength(50);
            Property(c => c.Email).IsRequired();
        }
    }
}
