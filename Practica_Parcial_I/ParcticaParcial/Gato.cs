using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcticaParcial
{
    public class Gato : Mascota
    {
        #region CONSTRUCTORES

        public Gato(string name , string raza) :base(name,raza)
        { 
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Permite comparar varios objetos.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool rta = false;
            if(obj is Gato)
            {
                rta = this == (Gato)obj;
            }
            return rta;
        }

        /// <summary>
        /// Sobre escritutra que muestras toda la informacion del Gato.
        /// </summary>
        /// <returns></returns>
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Gato - \n");
            sb.AppendFormat(base.DatosCompletos());
            sb.AppendLine();

            return sb.ToString();
        }

        /// <summary>
        /// retorna la ficha del gato.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Ficha();
        }
        #endregion

        #region SOBRECARGAS

        /// <summary>
        ///  TRUE = seran iguales si comparten Nombre,Raza
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator == (Gato g1, Gato g2)
        {
            bool rta = false;
            if ((Mascota)g1 == (Mascota)g2)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator != (Gato g1, Gato g2)
        {
            return !(p1 == p2);
        }

        #endregion
    }
}
