using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_lavadero
{
    public class Moto : Vehiculo
    {
        #region ATRIBUTOS

        protected float cilindraje;

        #endregion

        #region METODOS

        public string mostrarMoto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("TIPO : MOTO\n");
            sb.Append(base.Mostrar());
            sb.AppendFormat("CILINDRAJE : {0}\n", this.cilindraje);
            sb.AppendLine();

            return  sb.ToString();

        }
        #endregion

        #region CONSTRUCTORES
        public Moto (string patente, byte ruedas, eMarcas marca, float clindraje) : base(patente, ruedas, marca)
        {
            this.cilindraje = clindraje;
        }
        #endregion
    }
}
