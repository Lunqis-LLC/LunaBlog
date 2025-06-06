namespace LunaBlog.Database.BlogsTables
{
    public class BlogPostsVersion  : BlogPosts
    {
        public required BlogPosts Post { get; set; }

    }
}
