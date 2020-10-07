using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik._2A
{
    public class Auto : Vehiculo
    {
        #region ATRIBUTOS

        public ETipo tipo;

        #endregion

        #region CONSTRUCTOR

        public Auto (string modelo,float precio,Fabricante fabri,ETipo tipo):base(precio,modelo,fabri)
        {
            this.tipo = tipo;
        }

        #endregion

        #region METODOS

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Auto) 
            {
                retorno = this == (Auto)obj; 
            }

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            {
                sb.AppendLine();
                sb.AppendLine((string)(Vehiculo)this);
                sb.AppendFormat("Precio: {0}", (Single)this);
                sb.AppendLine();
                sb.AppendFormat("Tipo: {0}", this.tipo);
            }

            return sb.ToString();
        }
        #endregion

        #region SOBRECARGAS

        public static explicit operator Single (Auto a)
        {
            return a.precio;
        }

        public static bool operator == (Auto a, Auto b)
        {
            bool retorno = false;
            // igualdad en vehiculo y tipo 
            if ((Vehiculo)a == b && a.tipo == b.tipo)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        #endregion
    }
}
