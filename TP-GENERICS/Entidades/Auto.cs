using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Auto
    {
        #region ATRIBUTOS
        protected string _color;
        protected string _marca;
        #endregion

        #region PROPIEDADES

        /// <summary>
        /// Propiedad que permite obtener el color del auto.
        /// </summary>
        public string Color { get { return this._color; } }

        /// <summary>
        /// Propiedad que permite obtener la marca del auto.
        /// </summary>
        public string Marca { get { return this._marca; } }

        #endregion

        #region CONSTRUCTORES

        /// <summary>
        /// Constructor parametrizado. 
        /// </summary>
        /// <param name="col"></param>
        /// <param name="mar"></param>
        public Auto(string col, string mar)
        {
            this._color = col;
            this._marca = mar;
        }

        #endregion

        #region METODOS

        public override bool Equals(object obj)
        {
            bool rta = false;
            if( obj is Auto) // si el objeto es auto 
            {
                rta = this == (Auto)obj; // se compararan por su == 
            }
            return rta;
        }

        /// <summary>
        /// Polimorfismo para mostrar la info del auto. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Marca: {0}", this._marca);
            sb.AppendFormat(" - Color: {0}", this._color);                    
            sb.AppendLine();

            return sb.ToString();
        }

        #endregion

        #region SOBRECARGAS

        /// <summary>
        /// Retornara "TRUE" unicamente si ambos autos tienen mismo color y marca. 
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator == (Auto a1, Auto a2)
        {
            bool rta = false;
            if( a1._color == a2._color && a1._marca == a2._marca)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator != (Auto a1, Auto a2)
        {

            return !(a1==a2);
        }
        #endregion
    }


}