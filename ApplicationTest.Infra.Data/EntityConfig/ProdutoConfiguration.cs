﻿using System.Data.Entity.ModelConfiguration;
using ApplicationTest.Domain.Entities;

namespace ApplicationTest.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoID);
            Property(p => p.Nome).IsRequired().HasMaxLength(100);
            Property(p => p.Valor).IsRequired();

            HasRequired(p => p.Cliente).WithMany().HasForeignKey(p => p.ClienteID);
        }
    }
}
