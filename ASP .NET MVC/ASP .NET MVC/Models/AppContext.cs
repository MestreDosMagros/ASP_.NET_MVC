using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace ASP_.NET_MVC.Models
{
    public class AppContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public AppContext(DbContextOptions<AppContext> options) : base(options) { }
    }
}
