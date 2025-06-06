namespace LunaBlog.Database.BlogsTables
{
    public class BlogComment : DBBase
    {
        public bool IsOpen { get; set; } = true;

        public List<BlogCommentDetail> Comments { get; set; } = [];
    }
}
