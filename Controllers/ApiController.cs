using Microsoft.AspNetCore.Mvc;
using prjAJAXHW.Models;

namespace prjAJAXHW.Controllers
{
    public class ApiController : Controller
    {
        private readonly DemoContext _context;

        public ApiController(DemoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //載入縣市
        public IActionResult Cities()
        {
            var cities = _context.Address.Select(a => a.City).Distinct();
            return Json(cities);
        }
        //根據縣市載入鄉鎮區
        public IActionResult Districts(string city)
        {
            var district = _context.Address.Where(a => a.City == city)
                .Select(a => a.SiteId).Distinct();
            return Json(district);
        }
        //根據鄉鎮區載入路名
        public IActionResult Roads(string SiteId)
        {
            var roads = _context.Address.Where(a => a.SiteId == SiteId)
                .Select(a => a.Road);
            return Json(roads);
        }

        public IActionResult CheckAccount(Members member)
        {
            var datas = _context.Members.Select(x => x.Name).ToList();
            if (datas.Where(x => x == member.Name).Any())
            {
                return Content("1");
            }
            return Content("");//空字串代表不存在
        }
    }
}
