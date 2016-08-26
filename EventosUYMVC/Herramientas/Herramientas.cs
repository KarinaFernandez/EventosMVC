using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Herramientas
    {
        public static bool esNumero(string dato)
        {
            bool retorno = false;
            ulong resultado = 0;
            retorno = ulong.TryParse(dato, out resultado);
            return retorno;
        }

        public static bool esNumeroDecimal(string dato)
        {
            bool retorno = false;
            decimal resultado = 0;
            retorno = decimal.TryParse(dato, out resultado);
            return retorno;
        }

        public static bool esTexto(string dato)
        {
            bool resultado = true;
            foreach (char c in dato)
            {
                if (!Char.IsLetter(c))
                    resultado = false;
            }
            return resultado;
        }

        public static bool nombreValido(string nombre)
        {
            bool resultado = true;

            if (nombre == "" || nombre.Length >= 15)
            {
                resultado = false;
            }
            return resultado;
        }

        public static bool apellidoValido(string apellido)
        {
            bool resultado = true;

            if (apellido == "" || apellido.Length >= 15)
            {
                resultado = false;
            }
            return resultado;
        }

        public static bool calleValida(string calle)
        {
            bool resultado = true;

            if (calle == "" || calle.Length >= 30)
            {
                resultado = false;
            }
            return resultado;
        }

        public static bool numeroValido(string numero)
        {
            bool resultado = true;

            if (numero == "" || numero.Length >= 6)
            {
                resultado = false;
            }
            return resultado;
        }

        public static bool pass_ok(string dato)
        {
            bool ok = false;

            if (dato.Length >= 4 && dato.Length <= 20)
            {
                ok = true;
            }
            return ok;
        }

        public static bool nombre_apellido_ok(string dato)
        {
            bool ok = false;

            if (dato.Length > 4 && dato.Length < 20)
            {
                ok = true;
            }
            return ok;
        }

        public static bool direccion_descripcion_ok(string dato)
        {
            bool ok = false;

            if (dato.Length > 5 && dato.Length < 30)
            {
                ok = true;
            }
            return ok;
        }

        public static bool ci_telefono_ok(string dato)
        {
            bool ok = false;

            if (dato.Length > 6 && dato.Length < 13 && esNumero(dato))
            {
                ok = true;
            }
            return ok;
        }

        public static bool esFecha(string pFecha)
        {
            DateTime date;
            bool result = DateTime.TryParse(pFecha, out date);
            return result;
        }

        public static bool esHora(string pHora)
        {
            bool result = false;
            DateTime fechaFinal;
            result = DateTime.TryParse(pHora, out fechaFinal);
            return result;
        }

        public static bool email_ok(string pEmail)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(pEmail);
                return addr.Address == pEmail;
            }
            catch
            {
                return false;
            }
        }

        public static bool esBool(string dato)
        {
            bool datoFinal;
            bool resultado = false;
            return resultado = bool.TryParse(dato, out datoFinal);
        }

        public static bool user_pass_ok(string dato)
        {
            return true;
        }
    }
}
