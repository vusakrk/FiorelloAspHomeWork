using FiorelloAsp.Models;
using Microsoft.EntityFrameworkCore;

namespace FiorelloAsp.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
        }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Introduction> Introductions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutInfo> AboutInfos { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Tastimonial> Tastimonials { get; set; }
        public DbSet<Instagram> Instagrams { get; set; }
        public DbSet<InstagramHashtag> InstagramHashtags { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<FooterSocial> FooterSocials { get; set; }


    }
}
