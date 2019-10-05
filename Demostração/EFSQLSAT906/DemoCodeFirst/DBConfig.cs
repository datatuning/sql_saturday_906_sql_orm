using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst
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

    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("server=x1-carbon\\sql2017dev;database=CodeFirst;user id=xxx;password=xxx")
        { }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
