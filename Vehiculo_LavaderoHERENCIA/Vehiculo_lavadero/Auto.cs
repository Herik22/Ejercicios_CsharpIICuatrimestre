using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_lavadero
{
     public class  Auto : Vehiculo
    {
        #region ATRIBUTOS

        protected  int cantidadAsientos;

        #endregion

        #region METODOS

        public string mostrarAuto ()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("TIPO : AUTO\n");
            sb.Append(base.Mostrar());  
            sb.AppendFormat("CANTIDAD ASIENTOS : {0}\n", this.cantidadAsientos);
            sb.AppendLine();

            return  sb.ToString() ;

        }

        #endregion

        #region CONSTRUCTOR

        public Auto ( string patente , byte ruedas,eMarcas marca,int asientos) : base(patente,ruedas,marca)
        {
            this.cantidadAsientos = asientos;
        }

        #endregion
    }


}
