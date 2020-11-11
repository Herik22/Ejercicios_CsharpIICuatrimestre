using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Parcial
{   
    /// <summary>
    /// Exepcion que sera lanzada siempre y cuando se intente superar la capacidad de la lista. 
    /// </summary>
    public class CartucheraLlenaException : Exception
    {
        #region CONSTRUCTORES
        /// <summary>
        /// constructor por defecto con mensaje por defecto. 
        /// </summary>
        public CartucheraLlenaException() : base("La cartuchera  esta llena ")
        { }

        #endregion
    }
}
