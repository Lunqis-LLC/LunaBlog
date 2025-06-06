using LunaBlog.Database.BlogsTables;
using LunaBlog.Database.SettingTables;
using Microsoft.EntityFrameworkCore;

namespace LunaBlog.Database
{
    public class LunaBlogDBContext(DbContextOptions<LunaBlogDBContext> options) : DbContext(options)
    {
        public DbSet<BlogPosts> BlogPosts { get; set; } = null!;
        public DbSet<BlogTags> BlogTags { get; set; } = null!;
        public DbSet<BlogUsers> BlogUsers { get; set; } = null!;
        public DbSet<BlogImages> BlogImages { get; set; } = null!;
        public DbSet<BlogComment> BlogComments { get; set; } = null!;
        public DbSet<BlogCommentDetail> BlogCommentDetails { get; set; } = null!;
        public DbSet<BlogPostsVersion> BlogPostsVersions { get; set; } = null!;
        public DbSet<BackgroundImages> BackgroundImages { get; set; } = null!;
    }
}
