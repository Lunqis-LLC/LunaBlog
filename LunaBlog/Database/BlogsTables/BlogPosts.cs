namespace LunaBlog.Database.BlogsTables
{
    public class BlogPosts : DBBase
    {
        public required string Title { get; set; }
        public required string Content { get; set; }

        public required BlogImages PostPictureUrl { get; set; }

        public required List<BlogUsers> Author { get; set; }

        public List<BlogTags> Tags { get; set; } = [];

        public BlogComment? Comments { get; set; }
    }
}
