using System;
using System.Collections.Generic;

namespace News.Models
{
    public partial class TblCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string UrlFriendly { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public virtual ICollection<TblNews> TblNews { get; set; }
    }
}
