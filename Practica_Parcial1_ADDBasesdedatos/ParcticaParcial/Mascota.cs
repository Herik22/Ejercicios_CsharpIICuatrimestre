using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcticaParcial
{
    public abstract class Mascota
    {
        #region ATRIBUTOS
        private string nombre;
        private string raza;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de solo lectura para el atributo nombre 
        /// </summary>
        public string Nombre 
        {
            get
            {
                return this.nombre;
            }
         }

        /// <summary>
        ///  Propiedad de solo lectura para el atributo raza
        /// </summary>
        public string Raza
        {
            get
            {
                return this.raza;
            }
        }
        #endregion

        #region CONSTRUCTORES

        /// <summary>
        /// Unico constructor parametrizado.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="raza"></param>
        public Mascota (string name , string raza)
        {
            this.nombre = name;
            this.raza = raza;
        }

        #endregion

        #region METODOS
        /// <summary>
        /// Retorna los datos completos de la mascoto
        /// </summary>
        /// <returns></returns>
        protected virtual string DatosCompletos ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} - {1}", Nombre, Raza);
            return sb.ToString();
        }

        protected abstract string Ficha ();
        
           
        

        #endregion

        #region SOBRECARGAS

        /// <summary>
        /// Compara si son iguales de nombre y raza, de ser asi retorna TRUE,
        /// False si no. 
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator == (Mascota m1, Mascota m2)
        {
            if (m1.Nombre == m2.Nombre && m1.Raza == m2.Raza)
            {
                return true;
            }
                return false;
        }

        public static bool operator != (Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
        #endregion
    }
}
