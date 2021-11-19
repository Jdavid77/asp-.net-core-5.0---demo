using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCORE_Demo.Data;
using ASPNETCORE_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASPNETCORE_Demo.Controllers
{
    public class ItemController : Controller
    {

        private readonly ApplicationDBContext _context;

        public ItemController(ApplicationDBContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            IEnumerable<Item> objList = _context.Items;
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            _context.Items.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
