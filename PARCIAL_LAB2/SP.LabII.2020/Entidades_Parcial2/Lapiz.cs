using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades_Parcial2
{
    public class Lapiz : Utiles, ISerializa, IDeserializa
    {
        #region ATRIBUTOS
        public ConsoleColor color;
        public ETipoTrazo trazo;
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

        #region 

        public Lapiz()
        { }
        /// <summary>
        ///  constructor parametrizaod que ademas llama al constructor de la base. 
        /// </summary>
        /// <param name="_color"></param>
        /// <param name="tTrazo"></param>
        /// <param name="marca_"></param>
        /// <param name="precio_"></param>
        public Lapiz(ConsoleColor _color, ETipoTrazo tTrazo, string marca_, double precio_)
            : base(marca_, precio_)
        {
            this.color = _color;
            this.trazo = tTrazo;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// hace publicos los datos del lapiz.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.UtilesToString());
            sb.AppendFormat("Color: {0}", this.color.ToString());
            sb.AppendLine();
            sb.AppendFormat("tipo de Trazo: {0}", this.trazo.ToString());
            sb.AppendLine();
            sb.AppendFormat("Precio cuidado? {0}", this.PreciosCuidados);
            sb.AppendLine();
            return sb.ToString();
        }
        #region IMPLEMENTACION ISERIALIZA
        /// <summary>
        /// Propiedad de solo lectura para la ruta de la serializacion.
        /// </summary>
        public string Path
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Arismendy.Herik.Lapiz.xml";
            }
        }
        /// <summary>
        /// Implementacion que permite serializar un objeto de tipo lapiz
        /// </summary>
        /// <returns></returns>
        public bool Xml()
        {
            bool rta = true;
            try
            {
                using (XmlTextWriter xmlTW = new XmlTextWriter(this.Path, Encoding.UTF8))
                {
                    XmlSerializer xmlS = new XmlSerializer(typeof(Lapiz));
                    xmlS.Serialize(xmlTW, this);
                }
            }
            catch (Exception)
            {

                rta = false;
            }
            return rta;
        }
        #endregion

        #region IMPLEMENTACION IDESERIALIZA

        bool IDeserializa.Xml(out Lapiz lapiz)
        {

            bool rta = true;
            try
            {
                using (XmlTextReader xmlTR = new XmlTextReader(this.Path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Lapiz));
                    lapiz = (Lapiz)ser.Deserialize(xmlTR);
                }
            }
            catch (Exception)
            {
                lapiz = new Lapiz();
                rta = false;
            }


            return rta;
        }

        #endregion  
        #endregion


    }
}
