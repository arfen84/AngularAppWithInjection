using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Data;
using Restauracje.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class RestauracjeController : Controller
    {
        ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> _userManager;
        public RestauracjeController(ApplicationDbContext _db, UserManager<ApplicationUser> userManager)
        {
            db = _db;
            _userManager = userManager;
        }
        // GET: Restauracje
        public ActionResult Index()
        {
            return View(db.Restauracje.ToList());
        }

        // GET: Restauracje/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Restauracje/Create
        public ActionResult Create()
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            var idk = _userManager.GetUserId(User);

            if (idk == null)
            {
                return RedirectToAction("Login", "Account", new { @returnUrl = "/Restauracje/Create" });
            }

            return View();
        }

        // POST: Restauracje/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var id = _userManager.GetUserId(User);

                Restauracja restauracja = new Restauracja();
                restauracja.Nazwa = collection["Nazwa"];
                restauracja.Link = collection["Link"];
                restauracja.Miasto = collection["Miasto"];
                restauracja.Email = collection["Email"];
                restauracja.Przyjecia = collection["przyjecie"];
                restauracja.iloscStolikow =Int32.Parse(collection["iloscStolikow"]);
                restauracja.MaxLiczbaGosci = Int32.Parse(collection["MaxLiczbaGosci"]);
                restauracja.rodzajKuchni = collection["rodzajKuchni"];
                restauracja.klimatLokalu = collection["klimatLokalu"];
                restauracja.DodatkoweUwagi = collection["DodatkoweUwagi"];
                restauracja.Adder = id;
                restauracja.Termin = DateTime.Today;

                db.Restauracje.Add(restauracja);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Restauracje/Edit/5
        public ActionResult Edit(int id)
        {
            Restauracja restauracja = db.Restauracje.Where(x => x.ID == id).FirstOrDefault();

            return View(restauracja);
        }

        // POST: Restauracje/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                Restauracja restauracja = db.Restauracje.Where(x => x.ID == id).FirstOrDefault();

                restauracja.Nazwa = collection["Nazwa"];
                restauracja.Link = collection["Link"];
                restauracja.Miasto = collection["Miasto"];
                restauracja.Email = collection["Email"];
                restauracja.Przyjecia = collection["Przyjecia"];
                restauracja.iloscStolikow = Int32.Parse(collection["iloscStolikow"]);
                restauracja.MaxLiczbaGosci = Int32.Parse(collection["MaxLiczbaGosci"]);
                restauracja.rodzajKuchni = collection["rodzajKuchni"];
                restauracja.DodatkoweUwagi = collection["DodatkoweUwagi"];

                db.Entry(restauracja).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index", "Restauracje");
            }
            catch
            {
                return View();
            }
        }

        // GET: Restauracje/Delete/5
        public ActionResult Delete(int id)
        {
            Restauracja restauracja = db.Restauracje.Where(x => x.ID == id).FirstOrDefault();

            return View(restauracja);
        }

        // POST: Restauracje/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Restauracja res = db.Restauracje.Where(x => x.ID == id).FirstOrDefault();
                if (res != null)
                {
                    db.Restauracje.Remove(res);
                    db.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}