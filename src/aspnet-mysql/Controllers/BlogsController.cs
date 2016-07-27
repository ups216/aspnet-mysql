using Microsoft.AspNetCore.Mvc;
using System.Linq;
using aspnet_mysql.Models;

namespace aspnet_mysql.Controller
{
    public class BlogsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private MyContext _context;

        public BlogsController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View (_context.Blogs.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Blog blog)
        {
            blog.UserId = 1;
            if (ModelState.IsValid)
            {
                _context.Blogs.Add(blog);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog);
        }


    }
}