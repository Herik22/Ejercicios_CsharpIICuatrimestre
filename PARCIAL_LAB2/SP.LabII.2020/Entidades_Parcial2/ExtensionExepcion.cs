using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Parcial2
{
    /// <summary>
    /// clase estatica que contendra los metodos de extension. 
    /// </summary>
    public static class ExtensionExepcion
    {

        #region METODO DE EXTENSION
        /// <summary>
        /// Metodo que se extiende a la clase CartucheraLLenaException y retorna un mensaje informando lo sucedido 
        /// </summary>
        /// <param name="cLE"></param>
        /// <returns></returns>
        public static string InformarNovedad(this CartucheraLlenaException cLE)
        {
            return "La cartuchera esta llena y no admite mas elementos.";
        }
        #endregion

    }
}
