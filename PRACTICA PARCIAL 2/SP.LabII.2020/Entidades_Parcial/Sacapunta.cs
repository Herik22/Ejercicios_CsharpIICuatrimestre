using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Parcial
{                   //Sacapunta-> deMetal:bool(público); 
                    //Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).
    public class Sacapunta : Utiles
    {
        #region ATRIBUTOS
        public bool deMetal;

        #endregion

        #region PROPIEDADES
        /// <summary>
        /// propiedad de solo lectura para los precios cuidados. 
        /// </summary>
        public override bool PreciosCuidados
        {
            get
            {
                return false;
            }
        }
        #endregion

        #region CONTRUCTORES
        public Sacapunta()
        { }

        /// <summary>
        /// Constructor parametrizado, el cual llama al constructor de la base. 
        /// </summary>
        /// <param name="isMetal_"></param>
        /// <param name="marca_"></param>
        /// <param name="precio_"></param>
        public Sacapunta(bool isMetal_, double precio_,string marca_)
            : base(marca_, precio_)
        {
            this.deMetal = isMetal_;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// hace publicos los datos del sacapunta.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.UtilesToString());
            sb.AppendFormat("es de Metal?: {0}", this.deMetal);
            sb.AppendLine();
            sb.AppendFormat("Precio cuidado? {0}", this.PreciosCuidados);
            return sb.ToString();
        }
        #endregion
    }
}
