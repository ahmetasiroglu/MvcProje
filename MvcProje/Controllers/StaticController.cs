using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class StaticController : Controller
    {
        Context context = new Context();
        // GET: Static
        public ActionResult Index()
        {
            var result = context.Categories.Count();
            var result2 = context.Headings.Count(x => x.Category.CatagoryID == 7);
            var result3 = context.Writers.Count(x => x.WriterName.Contains("a"));
            var result4 = context.Headings.Max(x => x.Category.CatagoryName);
            var result5 = context.Categories.Count(x => x.CatagoryStatus == true);
            var result6 = context.Categories.Count(x => x.CatagoryStatus == false);

            ViewBag.CategoryCount = result;
            ViewBag.Heading = result2;
            ViewBag.Writer = result3;
            ViewBag.HeadingMax = result4;
            ViewBag.StatusFark = (result5 - result6);

            return View();
        }
    }
}