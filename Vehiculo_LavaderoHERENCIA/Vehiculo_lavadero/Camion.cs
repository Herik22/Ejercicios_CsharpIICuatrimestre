using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_lavadero
{
    public class Camion : Vehiculo
    {
        #region ATRIBUTOS
        protected int tara;
        #endregion

        #region METODOS

        public string mostrarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("TIPO : CAMION\n");
            sb.Append(base.Mostrar());
            sb.AppendFormat("CANTIDAD TARA : {0}\n", this.tara);
            sb.AppendLine();

            return sb.ToString();

        }


        #endregion

        #region CONSTRUCTORES
        public Camion (string patente, byte ruedas, eMarcas marca, int tara  ) : base (patente, ruedas ,marca)
        {
            this.tara = tara;
        }
        #endregion 
    }
}
