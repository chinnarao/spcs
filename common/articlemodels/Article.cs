using System;

namespace common.articlemodels
{
    public class Article
    {
        public Int64 ArticleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string License { get; set; }
        public string Commits { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserAvatar { get; set; }
        public string BiodataURL { get; set; }
        public bool HireMe { get; set; }
        public string OpenSourceUrls { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserEmail { get; set; }
        public string NatureKeysComma { get; set; } //sql server , c#
        public string RelatedTo1 { get; set; }
        public string RelatedTo12 { get; set; }
        public string RelatedTo123 { get; set; }
        public string RelatedTo1234 { get; set; }
        public string RelatedTo12345 { get; set; }
        public string AttachmentURLsComma { get; set; }
        public string SocialURLsWithComma { get; set; }
        public string Votes { get; set; }
        public string TechVersionsComma { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public string Tag1 { get; set; }
        public string Tag2 { get; set; }
        public string Tag3 { get; set; }
        public string Tag4 { get; set; }
        public string Tag5 { get; set; }
        public string Tag6 { get; set; }
        public string Tag7 { get; set; }
        public string Tag8 { get; set; }
        public string Tag9 { get; set; }
        public string Tag10 { get; set; }
        public string Tag11 { get; set; }
        public string Tag12 { get; set; }
    }
}
