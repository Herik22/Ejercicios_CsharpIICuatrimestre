using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInterface
{
    public abstract class Vehiculo
    {
        #region ATRIBUTOS
        protected double _precio;
        #endregion

        #region CONSTRUCTORES

        public Vehiculo (double precio)
        {
            this._precio = precio;
        }

        #endregion

        #region METODOS

        public abstract void MostrarPrecio(); // SE DEBE ESPECIFICAR QUE ES ABSTRACTA

        #endregion
    }


}
