using EF_CORE_PlayGround.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_CORE_PlayGround
{
    public class BloggingContext :DbContext
    {
       public DbSet<Blog> Blogs { get; set; }
       public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-M947CDC;Database=DB_PlayGround;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
