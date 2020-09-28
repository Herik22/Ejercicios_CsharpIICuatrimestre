using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_lavadero
{
    public class Vehiculo
    {
        #region ATRIBUTOS
        protected string patente;
        protected byte cantRuedas;
        protected eMarcas marca;
        #endregion

        #region METODOS

        /// <summary>
        /// Muestra la informacion de un Vehiculo.
        /// </summary>
        /// <returns></returns>
        protected string Mostrar ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("PATENTE: {0}", this.getPatente);
            sb.AppendLine();
            sb.AppendFormat("CANTIDAD DE RUEDAS: {0}", cantRuedas);
            sb.AppendLine();
            sb.AppendFormat("MARCA: {0}", this.getMarca);

            return sb.ToString();
        }
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de lectura para el  atributo patente.
        /// </summary>
        public string getPatente
        {
            get
            {
                return this.patente;
            }
        }
        /// <summary>
        /// Propiedad de lectura para el  atributo marca.
        /// </summary>
        public eMarcas getMarca // propfull con 2 tabs
        {
            get
            {
                return this.marca;
            }
        }
        #endregion

        #region CONSTRUCTORES

        public Vehiculo (string patentee, byte ruedas,eMarcas marca)
        {
            this.patente = patentee;
            this.cantRuedas = ruedas;
            this.marca = marca;
        }

        #endregion

        #region SOBRECARGAS
        /// <summary>
        /// Si la patente y marca son iguales retornara TRUE.
        /// Caso contrario retornara FALSE
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator + (Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            if ( v1.getPatente == v2.getPatente && v1.marca == v2.marca)
            {
                retorno = true;
            }

                return retorno;
        }

        #endregion 


        /*public eMarcas setMarca   PROPIEDAD DE ESCRITURA 
        {
            set
            {
                 this.marca = value;
            }
        }*/
    }
}
