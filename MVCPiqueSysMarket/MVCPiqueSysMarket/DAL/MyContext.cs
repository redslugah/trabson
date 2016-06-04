using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCPiqueSysMarket.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVCPiqueSysMarket.DAL
{
    public class MyContext : DbContext
    {
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Cliente> Usuarios { get; set; }

        public MyContext() : base("Data Source=(localdb)\\v11.0;Initial Catalog=TrabalhoPO;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}