namespace LunaBlog.Database.BlogsTables
{
    public class BlogTags : DBBase
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public ICollection<BlogPosts> Posts { get; set; } = [];
        public string? TagPictureUrl { get; set; }
    }
}
