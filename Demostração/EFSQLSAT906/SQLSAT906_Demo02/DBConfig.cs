using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLSAT906_Demo02
{
    class DBConfig
    {
    }
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal LimiteCredito { get; set; }
    }
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            //this.ToTable("Cliente");
            this.HasKey(x => x.Id);
            this.Property(x => x.Nome).IsRequired().HasMaxLength(100).HasColumnType("varchar");
            this.Property(x => x.CpfCnpj).IsRequired().HasMaxLength(14).HasColumnType("varchar");
            this.Property(x => x.DataCadastro).HasColumnType("date");
            this.Property(x => x.LimiteCredito).HasColumnType("decimal").HasPrecision(10, 2);
            this.HasIndex(x => x.Nome);
        }
    }

    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("server=x1-carbon\\sql2017dev;database=SQLSAT906_Demo02;user id=xxx;password=xxx")
        { }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
        }
    }

}
