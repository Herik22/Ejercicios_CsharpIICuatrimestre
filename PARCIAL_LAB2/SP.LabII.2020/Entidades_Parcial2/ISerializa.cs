using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Parcial2
{
    public interface ISerializa
    {
        
        #region METODOS
        /// <summary>
        /// Metodo que permitira serializar Xml
        /// </summary>
        /// <returns></returns>
        bool Xml();
        /// <summary>
        /// Propiedad de lectura para la ruta.
        /// </summary>
        string Path { get; }
        #endregion
    }
}
