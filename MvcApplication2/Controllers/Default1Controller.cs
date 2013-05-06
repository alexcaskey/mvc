using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{ 
    public class Default1Controller : Controller
    {
        private TestContext db = new TestContext();

        //
        // GET: /Default1/

        public ViewResult Index()
        {
            return View(db.People.ToList());
        }

        //
        // GET: /Default1/Details/5

        public ViewResult Details(int id)
        {
            Person person = db.People.Find(id);
            return View(person);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(person);
        }
        
        //
        // GET: /Default1/Edit/5
 
        public ActionResult Edit(int id)
        {
            Person person = db.People.Find(id);
            return View(person);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        //
        // GET: /Default1/Delete/5
 
        public ActionResult Delete(int id)
        {
            Person person = db.People.Find(id);
            return View(person);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Person person = db.People.Find(id);
            db.People.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}