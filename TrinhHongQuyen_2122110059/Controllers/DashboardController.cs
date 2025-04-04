using Microsoft.AspNetCore.Mvc;
using TrinhHongQuyen_2122110059.Models;
using TrinhHongQuyen_2122110059.Services;
using TrinhHongQuyen_2122110059.Data;
using TrinhHongQuyen_2122110059.Model;

namespace TrinhHongQuyen_2122110059.Controllers
{
    public class DashboardController : Controller
    {
        private readonly DashboardService _dashboardService;
        private readonly AppDbContext _context;

        public DashboardController(DashboardService dashboardService, AppDbContext context)
        {
            _dashboardService = dashboardService;
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new DashboardViewModel
            {
                Banners = _dashboardService.GetBanners(),
                Users = _dashboardService.GetUsers(),
                Categories = _dashboardService.GetCategories(),
                Products = _dashboardService.GetProducts()
            };

            return View(viewModel);
        }

        // Thêm Banner
        public IActionResult AddBanner()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBanner(Banner banner)
        {
            if (ModelState.IsValid)
            {
                _context.Banners.Add(banner);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(banner);
        }

        // Sửa Banner
        public IActionResult EditBanner(int id)
        {
            var banner = _context.Banners.Find(id);
            if (banner == null)
                return NotFound();
            return View(banner);
        }

        [HttpPost]
        public IActionResult EditBanner(Banner banner)
        {
            if (ModelState.IsValid)
            {
                _context.Banners.Update(banner);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(banner);
        }

        // Xóa Banner
        public IActionResult DeleteBanner(int id)
        {
            var banner = _context.Banners.Find(id);
            if (banner != null)
            {
                _context.Banners.Remove(banner);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // Các phương thức tương tự cho User, Category và Product

        // Thêm User
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // Sửa User
        public IActionResult EditUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
                return NotFound();
            return View(user);
        }

        [HttpPost]
        public IActionResult EditUser(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // Xóa User
        public IActionResult DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // Thêm Category, Sửa Category, Xóa Category tương tự như trên

        // Thêm Product, Sửa Product, Xóa Product tương tự như trên
    }
}
