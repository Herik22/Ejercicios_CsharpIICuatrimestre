using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Parcial
{ 
    /// <summary>
    /// clase estatica que contendra los metodos de extension. 
    /// </summary>
    public static class ExtensionExepcion
    {

        #region METODO DE EXTENSION
        public static string InformarNovedad(this CartucheraLlenaException cLE)
        {
            return "La cartuchera esta llena y no admite mas elementos.";
        }
        #endregion

    }
}
