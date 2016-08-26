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
    public class ReservaController : Controller
    {
        private EventosUYContext db = new EventosUYContext();

        //
        // GET: /Reserva/

        public ActionResult Index()
        {
            return View(db.Reservas.ToList());
        }

        //
        // GET: /Reserva/Details/5

        public ActionResult Details(int id = 0)
        {
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        //
        // GET: /Reserva/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Reserva/Create

        [HttpPost]
        public ActionResult Create(Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                db.Reservas.Add(reserva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reserva);
        }

        //
        // GET: /Reserva/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        //
        // POST: /Reserva/Edit/5

        [HttpPost]
        public ActionResult Edit(Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reserva).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reserva);
        }

        //
        // GET: /Reserva/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Reserva reserva = db.Reservas.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        //
        // POST: /Reserva/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Reserva reserva = db.Reservas.Find(id);
            db.Reservas.Remove(reserva);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //
        //  GET: /Evento/Reservar/5

        public ActionResult Reservar(int id = 0)
        {
            //Captura el id evento desde EventoController
            id = int.Parse(TempData["idEvento"].ToString());
            Evento evento = db.Eventos.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            Reserva rsv = new Reserva();
            Usuario pUsu = new Usuario();
            rsv.Evento = evento;
            rsv.Usuario = db.Usuarios.Find("1234567");
            return View(rsv);
        }

        
        //POST: 
        [HttpPost]
        public ActionResult Reservar(Reserva pReserva)
        {
            if (ModelState.IsValid)
            {
                int cant = pReserva.Cant;
                if (pReserva.Evento == null)
                {
                    return HttpNotFound();
                }

                if (cant <= pReserva.Evento.Capacidad - pReserva.Evento.EntradasVendidas)
                {
                    pReserva.Evento.EntradasVendidas = pReserva.Evento.EntradasVendidas + cant;
                    db.Reservas.Add(pReserva);
                    //Falta agregar en la bd de Usuario el evento reservado
                    try
                    {
                        db.Entry(pReserva.Usuario).State = EntityState.Modified;
                    
                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
            return View(pReserva);
        }
        //
    }
}