using Agencia.Model;
using Microsoft.EntityFrameworkCore;

namespace Agencia.Data
{


  public class DataContext : DbContext
  {

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<Client> Agencia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, Name = "Fernanda", DataNasc = "11-11-2001", Email = "ferrecode@recode.com", Phone = "1111111111111", IconeClient = "https://cdn.pixabay.com/photo/2017/03/31/17/44/avatar-2191933_1280.png"},
                new Client { Id = 2, Name = "Felipe", DataNasc = "11-11-2001", Email = "feliperecode@recode.com",Phone = "2222222222", IconeClient = "https://cdn.pixabay.com/photo/2017/03/31/17/44/avatar-2191934_960_720.png"},
                new Client { Id = 3, Name = "Nancy", DataNasc = "11-11-2001", Email = "Nancyrecode@recode.com",Phone = "3333333333", IconeClient = "https://cdn.pixabay.com/photo/2017/03/31/17/44/avatar-2191933_1280.png"},
                new Client { Id = 4, Name = "Polliana", DataNasc = "11-11-2001", Email = "Pollirecode@recode.com",Phone = "444444444", IconeClient = "https://cdn.pixabay.com/photo/2017/03/31/17/44/avatar-2191933_1280.png"}
             
            );
        }
    }
}