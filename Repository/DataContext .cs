using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataContext : DbContext
    {
        public DataContext() : base(Repository.Properties.Resources.ConnectionDB){ }
        public DbSet<Model.Cliente> Clientes { get; set; }
        public DbSet<Model.Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Model.Cliente>().HasMany(x => x.Enderecos).WithRequired(x => x.Cliente).WillCascadeOnDelete();               
        }       
    }
}
