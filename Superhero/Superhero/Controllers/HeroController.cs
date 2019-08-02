using Superhero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superhero.Controllers
{
    public class HeroController : Controller
    {
        ApplicationDbContext db;
        // GET: Hero
		public HeroController()
		{
			db = new ApplicationDbContext();
		}
        public ActionResult Index()
        {
            return View(db.Heroes.ToList());
        }

        // GET: Hero/Details/5
        public ActionResult Read(int id)
        {
            Hero hero = db.Heroes.Where(h => h.HeroId == id).Single();
            return View(hero);
        }

        // GET: Hero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hero/Create
        [HttpPost]
        public ActionResult Create(Hero hero)
        {
            try
            {
                db.Heroes.Add(hero);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Edit/5
        public ActionResult Update(int id)
        {
            Hero hero = db.Heroes.Where(h => h.HeroId == id).Single();
            return View(hero);
        }

        // POST: Hero/Edit/5
        [HttpPost]
        public ActionResult Update(Hero hero)
        {
            Hero foundHero = db.Heroes.Where(h => h.HeroId == hero.HeroId).Single();
            try
            {
                foundHero.Name = hero.Name;
                foundHero.AlterEgo = hero.AlterEgo;
                foundHero.PrimaryAbility = hero.PrimaryAbility;
                foundHero.SecondaryAbility = hero.SecondaryAbility;
                foundHero.Catchphrase = hero.Catchphrase;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Delete/5
        public ActionResult Delete(int id)
        {
            Hero hero = db.Heroes.Where(h => h.HeroId == id).Single();
            return View(hero);
        }

        // POST: Hero/Delete/5
        [HttpPost]
        public ActionResult Delete(Hero hero)
        {
            try
            {
                db.Heroes.Remove(hero);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
