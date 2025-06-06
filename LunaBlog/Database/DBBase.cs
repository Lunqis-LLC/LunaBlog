using System.ComponentModel.DataAnnotations;

namespace LunaBlog.Database
{
    public class DBBase
    {
        [Key]
        public int SEQID { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public void UpdateTimestamps()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
