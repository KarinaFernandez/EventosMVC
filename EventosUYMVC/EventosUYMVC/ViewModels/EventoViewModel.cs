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

namespace EventosUYMVC.ViewModels
{
    public class EventoViewModel
    {
        public Evento unEvento { get; set; }
        public Usuario Usuario { get; set; }
        public int CantEntradas { get; set; }

        public bool GuardarImagen(HttpPostedFileBase imagen)
        {
            bool pudoGuardar = false;
            if (imagen != null)
            {
                if (imagen.FileName.Contains(".jpg") || imagen.FileName.Contains(".png"))
                {
                    string ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Curriculums");
                    if (!System.IO.Directory.Exists(ruta))
                        System.IO.Directory.CreateDirectory(ruta);

                    ruta = System.IO.Path.Combine(ruta, imagen.FileName);
                    imagen.SaveAs(ruta);
                    this.unEvento.Imagen = ruta;
                    pudoGuardar = true;
                }
            }
            return pudoGuardar;
        }
    }
}