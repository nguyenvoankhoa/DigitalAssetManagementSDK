using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAssetManagement.Action
{
    public class ImageUploadResult
    {
        public Guid Id { get; set; }
        public string PublicId { get; set; }
        public string DisplayName { get; set; }
        public ResourceType Type { get; set; }
        public string ExtensionFile { get; set; }
        public long Size { get; set; }
        public string FilePath { get; set; }
        public string ThumbnailUrl { get; set; }
        public string OriginalFilename { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
