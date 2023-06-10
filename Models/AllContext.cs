using Microsoft.EntityFrameworkCore;
using LibreriaVirtualWebApi.Models;

namespace LibreriaVirtualWebApi.Models
{
    public class AllContext : DbContext
    {
        public AllContext(DbContextOptions<AllContext> options) : base(options)
        {

        }

        public DbSet<Authors> Autores { get; set; }

        public DbSet<LibreriaVirtualWebApi.Models.Books>? Books { get; set; }

        public DbSet<LibreriaVirtualWebApi.Models.Categories>? Categories { get; set; }

        public DbSet<LibreriaVirtualWebApi.Models.Editorials>? Editorials { get; set; }

        public DbSet<LibreriaVirtualWebApi.Models.Roles>? Roles { get; set; }

        public DbSet<LibreriaVirtualWebApi.Models.Users>? Users { get; set; }
    }
}
