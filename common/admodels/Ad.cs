using System;

namespace common.admodels
{
    public class Ad
    {
        public Int64 AdId { get; set; }
        public Guid AdAssetId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserAvatar { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ActiveDays { get; set; } //Max 30 days
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
