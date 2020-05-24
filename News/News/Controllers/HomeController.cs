using Microsoft.AspNetCore.Mvc;
using News.Models;
using System.Linq;

namespace News.Controllers
{
    public class HomeController : BaseController
    {
        private readonly NewsContext _context;

        public HomeController(NewsContext context) : base(context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Get data header page
            CreateHeader(0);

            mymodel.LsCategory = LIST_CATEGORY;
            mymodel.LsNew = LIST_NEWS.OrderByDescending(obj=>obj.DateNews).ToList();
            return View(mymodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
