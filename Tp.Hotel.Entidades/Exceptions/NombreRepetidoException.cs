using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp.Hotel.Entidades.Exceptions
{
    public class NombreRepetidoException : Exception
    {

        public NombreRepetidoException(string nombre) : base("El nombre " + nombre.ToUpper() + " ya se encuentra ingresado en nuestra base de datos.")
        {

        }
    }
}
