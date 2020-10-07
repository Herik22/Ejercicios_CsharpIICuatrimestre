using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik._2A
{
    public class Fabricante
    {
        #region ATRIBUTOS

        private string marca;
        private EPais pais;

        #endregion

        #region CONSTRUCTORES

        public Fabricante(string marca,EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }

        #endregion

        #region SOBRECARGAS

       public static implicit operator string (Fabricante f)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} - {1}", f.marca, f.pais);
            return sb.ToString();
        }

        /// <summary>
        /// seran iguales si comparten marca y pais
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <returns></returns>
        public static bool operator == (Fabricante f1, Fabricante f2)
        {
            bool retorno = false;
            if(f1.marca == f2.marca && f1.pais == f2.pais)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator != (Fabricante f1, Fabricante f2)
        {
            return !(f1 == f2);
        }
        #endregion
    }
}
