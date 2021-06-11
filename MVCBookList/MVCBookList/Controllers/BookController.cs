using MVCBookList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBookList.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
            return View();
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        [NonAction]
        public List<Book> GetBookList()
        {
            return new List<Book>{
      new Book{
         Id = 1,
         Name = "Be Kind",
         Description = "From asking the new girl to play to standing up for someone being bullied, this moving story explores what kindness is, " +
         "and how any act, big or small, can make a difference—or at least help a friend."
         
      },

      new Book{
         Id = 2,
         Name = "Panchatantra for Children",
         Description = "The classic characters in these stories have been brought to life using simple language and attractive illustrations, " +
         "making Panchatantra for Children a must-have, must-read book for all children."
          },

      new Book{
         Id = 3,
         Name = "The Journey of the Marmabill",
         Description = "A little marmabill loses her home to a grumpy creature and thus sets off on a mission to find a new home--and " +
         "she makes some friends along the way"
             },

      new Book{
         Id = 4,
         Name = "I Am the Dog",
         Description = "The question is: Who has the better deal? Story maestro Daniel Pinkwater collaborates once again with the gifted " +
         "illustrator Jack E. Davis for a boy-and - dog escapade that's sure to set tails a-wagging"
          },
         };
        }

    }
}
