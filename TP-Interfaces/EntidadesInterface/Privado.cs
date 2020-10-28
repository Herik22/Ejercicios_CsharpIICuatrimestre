using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInterface
{
    class Privado : Avion
    {
        #region ATRIBUTOS 

        protected int _valoracionServicioAbordo;

        #endregion

        #region CONSTRUCTORES

        public Privado ( double precio, int velocidad, int valoracion) : base (precio,velocidad)
        {
            this._valoracionServicioAbordo = valoracion;
        }

        #endregion

        #region METODOS 

        public override void MostrarPrecio() //REVISAR NO ESTOY SEGURO !!!!
        {
            base.MostrarPrecio();
        }

        #endregion

        #region IMPLEMENTACION IAFIP
        #endregion
    }
}
