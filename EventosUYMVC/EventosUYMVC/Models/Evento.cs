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


namespace EventosUYMVC.Models
{
    public class Evento
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public string Artistas { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }

        [Required]
        public string DireccionLugar { get; set; }

        public string BarrioLugar { get; set; }

        public string DescripcionLugar { get; set; }

        public string NombreLugar { get; set; }

        public int EntradasVendidas { get; set; }

        [Required]
        public int Capacidad { get; set; }

        public string Imagen { get; set; }

        [Required]
        public virtual Precio Precio { get; set; }

        public bool Activo { get; set; }

        // VER SI ESTO ES NECESARIO
       public virtual List<Reserva>Reservas { get; set; }
       public virtual List<Usuario> UsuariosReservaron { get; set; }

    }
}