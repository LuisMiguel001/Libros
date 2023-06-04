using Microsoft.EntityFrameworkCore;
using Libros.Models;

namespace Libros.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> Options) 
            :base(Options) { }

        public DbSet<Libro> Libro { get; set; }
    }
}
