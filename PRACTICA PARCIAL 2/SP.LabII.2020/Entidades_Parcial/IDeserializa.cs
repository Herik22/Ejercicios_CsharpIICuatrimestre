using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Parcial
{
   public interface IDeserializa
    {
        #region METODOS

        bool Xml(out Lapiz lapiz) ;

        #endregion
    }
}
