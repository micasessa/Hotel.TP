using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp.Hotel.Entidades.Exceptions
{
    public class DniRepetidoException : Exception
    {
        public DniRepetidoException(int dni) : base("El DNI " + dni + " ya se encuentra ingresado en nuestra base de datos.")
        {

        }
    }
}
