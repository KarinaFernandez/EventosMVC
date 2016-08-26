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
    public class Precio
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPrecio { get; set; }

        [Required]
        public decimal Valor{get;set;}
               
        public string Descripcion {get;set;}

        public string Categoria {get;set;}
        
      

    }
}