using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Parcial
{           //Goma-> soloLapiz:bool(público); 
            //PreciosCuidados->true; 
            //Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).
    public class Goma : Utiles
    {
        #region ATRIBUTOS
        public bool soloLapiz;
     
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// propiedad de solo lectura para los precios cuidados. 
        /// </summary>
        public override bool PreciosCuidados
        {
            get
            {
                return true;
            }
        }
        #endregion

        #region CONTRUCTORES
        public Goma ()
        { }
        /// <summary>
        /// Constructor parametrizado, el cual llama al constructor de la base. 
        /// </summary>
        /// <param name="soloLapiz_"></param>
        /// <param name="marca_"></param>
        /// <param name="precio_"></param>
        public Goma (bool soloLapiz_, string marca_, double precio_)
            : base(marca_, precio_)
        {
            this.soloLapiz = soloLapiz_;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// hace publicos los datos de la goma.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.UtilesToString());
            sb.AppendFormat("Solo lapiz?: {0}", this.soloLapiz);
            sb.AppendLine();
            sb.AppendFormat("Precio cuidado? {0}", this.PreciosCuidados);
            sb.AppendLine();
            return sb.ToString();
        }
        #endregion
    }
}
