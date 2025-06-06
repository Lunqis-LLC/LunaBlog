namespace LunaBlog.Database.BlogsTables
{
    public class BlogImages : DBBase
    {
        public required string RawImageUrl { get; set; }
        public required string ThumbnailImageUrl { get; set; }
    }
}
