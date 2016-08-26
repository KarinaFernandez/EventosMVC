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
    public class Usuario
    {
       
        [Key]
        public string Ci { get; set; }
        
        [Required]
        public string Nombre { get; set; }
        
        [Required]
        public string Apellido { get; set; }

        [MinLength(7)]
        public string Telefono { get; set; }
        
       
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Rol { get; set; }
    
        public virtual List<Evento> EventosFavoritosList { get; set; }

        public virtual List<Evento> EventosReservaList { get; set; }
       
      
    }
}