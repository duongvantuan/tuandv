using Microsoft.AspNetCore.Mvc;
using News.constant;
using News.Models;
using News.Util;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace News.Controllers
{
    public class PostController : BaseController
    {
        private readonly NewsContext _context;

        public PostController(NewsContext context) : base(context)
        {
            _context = context;
        }

        [HttpGet("tuandv.html")]
        public IActionResult Index()
        {
            // Get data header page
            CreateHeader(0);
            return View(mymodel);
        }


        [HttpPost("news/insert.html")]
        public async Task<string> Post(TblNews tblNews)
        {
            try
            {
                tblNews.UrlFriendly = CommonUtil.UrlFriendly(tblNews.TitleNews);
                tblNews.DescriptionNews = CommonUtil.StripHTML(tblNews.Content);
                if (tblNews.DescriptionNews != null && tblNews.DescriptionNews.Length > 150)
                {
                    tblNews.DescriptionNews = tblNews.DescriptionNews.Substring(0, 150) + ComConst.READ_MORE;
                }

                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/images", tblNews.UrlFriendly + ".jpg");
                await LoadImageFromUrl(filePath, tblNews.UrlImg);

                tblNews.UrlImg = ComConst.URL + "/images/" + tblNews.UrlFriendly + ".jpg";
                tblNews.DateNews = DateTime.Now;
                _context.Add(tblNews);
                _context.SaveChanges();

                LIST_CATEGORY = _context.TblCategory.ToList();
                LIST_NEWS = _context.TblNews.ToList();
                return "thành công";
            } catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private async Task LoadImageFromUrl(string filePath, string url)
        {
            int width = 389;
            int height = 233;
            using (HttpClient httpClient = new HttpClient())
            using (HttpResponseMessage response = await httpClient.GetAsync(url))
            using (Stream inputStream = await response.Content.ReadAsStreamAsync())
            using (Bitmap temp = new Bitmap(new Bitmap(inputStream), new Size(width, height)))
                temp.Save(filePath, ImageFormat.Jpeg);
        }
    }
}
