using System.Collections.Generic;
using ASPNETCORE_Demo.Data;
using ASPNETCORE_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCORE_Demo.Controllers
{
    public class ExpenseController : Controller
    {

        private readonly ApplicationDBContext _context;

        public ExpenseController(ApplicationDBContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            IEnumerable<Expenses> list = _context.Expenses;
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expenses obj)
        {
            if (ModelState.IsValid)
            {
                _context.Expenses.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _context.Expenses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _context.Expenses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            
            _context.Expenses.Remove(obj); 
            _context.SaveChanges(); 
            return RedirectToAction("Index");
            
            
        }

        public IActionResult Update(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _context.Expenses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);


        }

    }
}