using Microsoft.AspNetCore.Mvc;
using News.constant;
using News.Models;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace News.Controllers
{
    public class BaseController : Controller
    {
        protected static dynamic mymodel = new ExpandoObject();

        protected static bool isLoadHeader = true;
        protected static bool isLoadDataHome = true;
        protected static bool isLoadDataAnime = true;

        protected static List<TblCategory> LIST_CATEGORY = null;
        protected static List<TblNews> LIST_NEWS = null;
        protected static List<TblAds> LIST_ADS = null;

        public BaseController(NewsContext context)
        {
            if (LIST_CATEGORY == null)
            {
                LIST_CATEGORY = context.TblCategory.ToList();
            }

            if (LIST_NEWS == null)
            {
                LIST_NEWS = context.TblNews.ToList();
            }

            if (LIST_ADS == null)
            {
                LIST_ADS = context.TblAds.ToList();
            }
        }

        static BaseController()
        {
            mymodel.URL = ComConst.URL;
        }

        protected void CreateHeader(int categoryId, string title="")
        {
            TblCategory category = LIST_CATEGORY.FirstOrDefault(o => o.CategoryId == categoryId);
            if (category == null)
            {
                category = LIST_CATEGORY.First(o => o.CategoryId == 1);
            }

            mymodel.ads1 = LIST_ADS[0].Ads;
            mymodel.ads2 = LIST_ADS[1].Ads;

            mymodel.TitLe = title != "" ? title : category.Title;
            mymodel.Description = category.Description;
            mymodel.Keywords = category.Keywords;
            mymodel.CategoryId = categoryId;

            List<TblNews> LsNewRecent = LIST_NEWS;
            if (categoryId != 0)
            {
                LsNewRecent = LsNewRecent.Where(o => o.CategoryId == categoryId).OrderByDescending(o => o.DateNews).Take(5).ToList();
            }
            mymodel.LsNewRecent = LsNewRecent;
        }
    }
}