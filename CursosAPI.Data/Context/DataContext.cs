using CursosAPI.Data.DataConfig;
using CursosAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CursosAPI.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EntidadeCursos>(new CursosConfiguration().Configure);
            base.OnModelCreating(builder);
        }
    }
}
