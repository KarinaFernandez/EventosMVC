using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utilidades;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventosUYMVC.Models;
using System.Data.Objects.SqlClient;
using System.Web.Mvc;


namespace EventosUYMVC.Models
{
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReserva { get; set; }

        [Required]
        public virtual Usuario Usuario { get; set; }

        [Required]
        public virtual Evento Evento { get; set; }

        [Required]
        public int Cant { get; set; }

      

        //public List<Evento> listadeEventos() {

        //    List<Evento> listAux = new List<Evento>();

        //    using (EventosUYContext eUy = new EventosUYContext())
        //    {
        //        var result = from e in eUy.Eventos
        //                 select e;

        //      listAux = result.ToList<Evento>();
        //    }

        //    return listAux;
                       
        
        //}

        // public Reserva()
        //{
            //EventosUYContext db = new EventosUYContext();
            //this.ListaEventos = (from t in db.Eventos
            //               select new SelectListItem
            //               {
            //                   Selected = false,
            //                   Text = t.Titulo,
            //                   Value = t.Id.ToString(),
            //               }).ToList(); 
        //}
        public Reserva() { }
    }
}