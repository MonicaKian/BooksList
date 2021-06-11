using MVCBookList.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBookList.Controllers
{
    public class BookController : Controller
    {
        private BoDBContext db = new BoDBContext();
        // GET: Book
        public ActionResult Index()
        {
            var books = from e in db.Books
                        orderby e.Id
                        select e;

            return View(books);
        }

        // GET: Book/ShowSearchForm
        public ActionResult ShowSearchForm()
        {
 

            return View();
        }
        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            var book = db.Books.Single(m => m.Id == id);
            return View(book);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(Book bo)
        {
            try
            {
                db.Books.Add(bo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {

            var book = db.Books.Single(m => m.Id == id);
            return View(book);
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var book = db.Books.Single(m => m.Id == id);
                if (TryUpdateModel(book))
                {
                    //To Do:- database code
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(book);
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            var book = db.Books.Single(m => m.Id == id);
            return View(book);
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var bo = db.Books.Single(m => m.Id == id);
            try
            {
                db.Books.Remove(bo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

       
    }
    public class BoDBContext : DbContext
    {
        public BoDBContext()
        { }
        public DbSet<Book> Books { get; set; }
    }

}
