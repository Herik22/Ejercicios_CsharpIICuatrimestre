using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInterface
{
    public static class Gestion
    {
        #region METODOS

        public static  double MostrarImpuestoNacional(IAFIP bienPunible)
        {

            return bienPunible.CalcularImpuesto();
        }

        #endregion
    }
}
