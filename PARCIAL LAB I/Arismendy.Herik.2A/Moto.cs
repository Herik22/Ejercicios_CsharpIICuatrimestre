using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik._2A
{
    public class Moto :Vehiculo
    {
        #region ATRIBUTOS
        public ECilindrada cilindrada;
        #endregion

        #region CONSTRUCTORES

        public Moto (string marca, EPais pais, string modelo,float precio,ECilindrada cilindrada) :base(marca,pais,modelo,precio)
        {
            this.cilindrada = cilindrada;
        }

        #endregion

        #region METODOS

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Moto)
            {
                retorno = this == (Moto)obj;
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
                sb.AppendFormat("Cilindraje: {0}", this.cilindrada);
            }

            return sb.ToString();
        }
        #endregion

        #region SOBRECARGAS

        public static implicit operator Single(Moto m)
        {
            return m.precio;
        }

        public static bool operator == (Moto a, Moto b)
        {
            bool retorno = false;
            // igualdad en vehiculo y cilindraje igual 
            if ((Vehiculo)a == b && a.cilindrada == b.cilindrada)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Moto a, Moto b)
        {
            return !(a == b);
        }

        #endregion
    }
}
