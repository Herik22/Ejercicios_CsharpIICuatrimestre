using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInterface
{
    public abstract class Auto : Vehiculo
    {

        #region ATRIBUTOS

        protected string _patente; // constructor y mostrar patente void 

        #endregion

        #region CONSTRUCTORES

        public Auto (double prec, string patente) : base (prec)
        {
            this._patente = patente;
        }

        #endregion

        #region METODOS

        public abstract void MostrarPatente();
        
        #endregion
    }
}
