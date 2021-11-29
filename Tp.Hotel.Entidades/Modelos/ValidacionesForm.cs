using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp.Hotel.Entidades.Modelos
{
    public static class ValidacionesForm
    {
        static ValidacionesForm()
        {

        }
        public static string ValidacionesAlta(string txt, string lbl)
        {
            if (txt == string.Empty)
            {
                throw new Exception("Falta ingresar el valor en el campo " + lbl);
            }
            return txt;
        }

        public static int ValidacionNumero(string txt)
        {
            if (!int.TryParse(txt, out int numero))
            {
                throw new Exception("Debe ingresar un valor con formato de número");
            }
            return numero;
        }

        public static DateTime ValidacionFecha(string txt)
        {
            if (!DateTime.TryParse(txt, out DateTime fecha))
            {
                throw new Exception("Debe ingresar un valor con formato de fecha");
            }
            return fecha;
        }

        public static void ValidarSeleccion(object objeto)
        {
            if (objeto == null)
            {
                throw new Exception("Debe seleccionar un objeto de la lista");
            }
            
        }
    }
}
