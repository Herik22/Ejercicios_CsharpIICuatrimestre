using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Parcial2
{
    /// <summary>
    /// clase publica y  abstracta de utiles.
    /// </summary>
    public abstract class Utiles
    {
        #region ATRIBUTOS

        public string marca;
        public double precio;

        #endregion

        #region PROPIEDADES
        /// <summary>
        /// propiedad de solo lectura y asbtracta para los precioscuidados
        /// </summary>
        public abstract bool PreciosCuidados { get; }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Utiles()
        { }
        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="marca_"></param>
        /// <param name="precio_"></param>
        public Utiles(string marca_, double precio_)
        {
            this.marca = marca_;
            this.precio = precio_;
        }

        #endregion

        #region METODOS
        /// <summary>
        /// Metodo protegido que retorna la informacion del util.
        /// </summary>
        /// <returns></returns>
        protected virtual string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendFormat("Marca: {0}", this.marca);
            sb.AppendLine();
            sb.AppendFormat("Precio: {0}", this.precio);
            sb.AppendLine();
            return sb.ToString();
        }
        /// <summary>
        /// Metodo que hace publica la informacion del util. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.UtilesToString();
        }

        #endregion




    }

}
