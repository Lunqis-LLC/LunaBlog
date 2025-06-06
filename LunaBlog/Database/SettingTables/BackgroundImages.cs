namespace LunaBlog.Database.SettingTables
{
    public class BackgroundImages : DBBase
    {
        public required string ImageUrl { get; set; } = string.Empty;
        public required string ThumbnailImageUrl { get; set; } = string.Empty;
        public required string Name { get; set; } = string.Empty;
        public required string Description { get; set; } = string.Empty;
    }
}
