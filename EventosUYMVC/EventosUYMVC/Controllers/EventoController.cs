using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventosUYMVC.Models;

namespace EventosUYMVC.Controllers
{
    public class EventoController : Controller
    {
        private EventosUYContext db = new EventosUYContext();

        //
        // GET: /Evento/

        public ActionResult Index()
        {
            return View(db.Eventos.ToList());
        }

        //
        // GET: /Evento/Details/5

        public ActionResult Details(int id = 0)
        {
            Evento evento = db.Eventos.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        public ActionResult Reservar(int id = 0)
        {
            //Asigna id evento
            TempData["idEvento"] = id;
            return RedirectToAction("../Reserva/Reservar");
        }

        // GET: /Evento/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Evento/Create

        [HttpPost]
        public ActionResult Create(Evento evento)
        {
            if (ModelState.IsValid)
            {

                db.Eventos.Add(evento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(evento);
        }

        //
        // GET: /Evento/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Evento evento = db.Eventos.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        //
        // POST: /Evento/Edit/5

        [HttpPost]
        public ActionResult Edit(Evento evento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evento);
        }

        //
        // GET: /Evento/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Evento evento = db.Eventos.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        //
        // POST: /Evento/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Evento evento = db.Eventos.Find(id);
            db.Eventos.Remove(evento);
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