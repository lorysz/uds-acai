using Infra.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infra
{
    public class Context : DbContext
    {
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Personalizacao> Personalizacao { get; set; }
        public DbSet<Sabor> Sabor { get; set; }
        public DbSet<Tamanho> Tamanho { get; set; }
        public DbSet<PedidoPersonalizado> PedidoPersonalizado { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
