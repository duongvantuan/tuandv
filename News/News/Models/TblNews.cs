using System;

namespace News.Models
{
    public partial class TblNews
    {
        public int IdNews { get; set; }
        public string TitleNews { get; set; }
        public string UrlFriendly { get; set; }
        public string DescriptionNews { get; set; }
        public string Content { get; set; }
        public DateTime? DateNews { get; set; }
        public int? CategoryId { get; set; }
        public string UrlImg { get; set; }

        public virtual TblCategory Category { get; set; }
    }
}
