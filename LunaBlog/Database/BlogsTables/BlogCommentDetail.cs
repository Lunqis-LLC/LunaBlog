namespace LunaBlog.Database.BlogsTables
{
    public class BlogCommentDetail
    {
        public required BlogComment Root { get; set; }

        public BlogCommentDetail? Parent { get; set; }

        public List<BlogCommentDetail> Replies { get; set; } = [];

        public required BlogUsers Author { get; set; }

        public required string Content { get; set; }
    }
}
