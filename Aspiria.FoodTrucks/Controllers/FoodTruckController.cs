using Aspiria.FoodTrucks.Filters;
using Aspiria.FoodTrucks.Models;
using Aspiria.FoodTrucks.Respositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspiria.FoodTrucks.Controllers
{
    public class FoodTruckController : Controller
    {
        private FoodTrucksRepository<FoodTruck> repo;

        public FoodTruckController(FoodTrucksRepository<FoodTruck> _repo)
        {
            repo = _repo;
        }

        public ActionResult Index([Bind("Day,Time")] DateTimeFilter filter)
        {
            return View(new FoodTrucksByDayAndTime { 
                Day= filter.Day,
                Time = filter.Time.TotalMilliseconds == 0? new TimeSpan( DateTime.Now.ToFileTime()) : filter.Time,
                FoodTrucks = repo.fetch(filter).ToList()
            });
        }

        // GET: FoodTruckController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FoodTruckController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodTruckController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FoodTruckController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FoodTruckController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FoodTruckController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FoodTruckController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
