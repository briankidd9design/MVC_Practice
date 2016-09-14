using Cars_MVC.Context;
using Cars_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cars_MVC.Controllers
{
    public class CarController : Controller
    {

        CarContext db = new CarContext();
        // GET: Car
        public ActionResult Index()
        {
            var cars = db.Cars.ToList();

            return View(cars);
        }

        public ActionResult OrderByPrice()
        {
            var cars = from c in db.Cars
                       orderby c.Price descending
                       select c;

            return View (cars);

        }

        public ActionResult OrderByRating()
        {
            var cars = from c in db.Cars
                       orderby c.Rating descending
                       select c;

            return View(cars);

        }


        // GET: Car/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Car/Create
        [HttpPost]
        public ActionResult Create(CarModel car)
        {
            try
            {
                db.Cars.Add(car);
                db.SaveChanges();
                // TODO: Add insert logic here
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View(car);
            }
        }

        // GET: Car/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Car/Edit/5
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

        // GET: Car/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Car/Delete/5
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
    }
}
