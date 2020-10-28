using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInterface
{
     public class Comercial : Avion
    {
        #region ATRIBUTOS 

        protected int _capacidadPasajeros;

        #endregion

        #region CONSTRUCTORES

        public Comercial (double precio, int velocidad, int capacidad ) : base(precio, capacidad)
        {
            this._capacidadPasajeros = capacidad;
        }

        #endregion
    }
}
