using api_consulta_cnpj.Data.Mapping;
using api_consulta_cnpj.Model;
using Microsoft.EntityFrameworkCore;

namespace api_consulta_cnpj.Data.Context
{
    public class cnpjcontext : DbContext
    {
        public DbSet<consultacnpj> consultacnpj { get; set; }

        public cnpjcontext(DbContextOptions<cnpjcontext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfiguration(new consultacnpjMap());
    }
}