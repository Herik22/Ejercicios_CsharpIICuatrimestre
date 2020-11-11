using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Parcial2
{
    public interface IDeserializa
    {
        #region METODOS
        /// <summary>
        /// Metodo a implementar que permitira deserializar un archivo xml.
        /// </summary>
        /// <param name="lapiz"></param>
        /// <returns></returns>
        bool Xml(out Lapiz lapiz);

        #endregion
    }
}
