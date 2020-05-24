using Microsoft.AspNetCore.Mvc;
using News.Models;
using System.Collections.Generic;
using System.Linq;

namespace News.Controllers
{
    public class NewsController : BaseController
    {
        private readonly NewsContext _context;

        public NewsController(NewsContext context) : base(context)
        {
            _context = context;
        }

        [HttpGet("category/{urlFriendly}.html")]
        public IActionResult Index(string urlFriendly)
        {
            // Get data header page
            TblCategory tblCategory = _context.TblCategory.Where(o => o.UrlFriendly == urlFriendly).First();
            CreateHeader(tblCategory.CategoryId);
            List<TblNews> lsTblNews = _context.TblNews.Where(o => o.CategoryId == tblCategory.CategoryId).ToList();

            mymodel.CategoryName = tblCategory.CategoryName;
            mymodel.LsNew = lsTblNews;
            return View(mymodel);
        }

        [HttpGet("category/{a}/{urlFriendly}.html")]
        public IActionResult News(string urlFriendly)
        {
            // Get data header page
            TblNews tblNews = LIST_NEWS.Where(o => o.UrlFriendly == urlFriendly).First();

            CreateHeader(tblNews.Category.CategoryId, tblNews.TitleNews);
            mymodel.News = tblNews;
            return View(mymodel);
        }
    }
}
