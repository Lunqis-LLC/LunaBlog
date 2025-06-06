namespace LunaBlog.Database.SettingTables
{
    public class Setting : DBBase
    {
        public required string SiteName { get; set; } = string.Empty;
        public required string SiteDescription { get; set; } = string.Empty;
        public required string SiteKeywords { get; set; } = string.Empty;
        public required string SiteAuthor { get; set; } = string.Empty;
        public required string SiteUrl { get; set; } = string.Empty;
        public required string SiteLogoUrl { get; set; } = string.Empty;
        public required bool EnableComments { get; set; } = true;
        public required bool EnableSearch { get; set; } = true;
    }
}
