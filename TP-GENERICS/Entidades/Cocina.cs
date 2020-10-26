using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Cocina
    {
        #region ATRIBUTOS 

        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        #endregion

        #region PROPIEDADES

        /// <summary>
        /// Propiedad de lectura para el dato. 
        /// </summary>
        public int Codigo { get { return this._codigo; } }
        public bool esIndustrial { get { return this._esIndustrial; } }
        public double Precio { get { return this._precio; } }

        #endregion

        #region CONSTRUCTORES

        public Cocina (int cod, double prec,bool esI)
        {
            this._codigo = cod;
            this._esIndustrial = esI;
            this._precio = prec;
        }

        #endregion 

        #region METODOS

        public override bool Equals(object obj)
        {
            bool rta = false;
            if(obj is Cocina)
            {
                rta = this == (Cocina)obj;
            }
            return rta  ;
        }
        /// <summary>
        /// Retornara la informacion de la cocina 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendFormat("Codigo: {0} - Precio: {1} - Es Industrial?: {2}",this._codigo,this._precio,this._esIndustrial);
            sb.AppendLine();

            return sb.ToString();
        }
        #endregion

        #region SOBRECARGAS
        /// <summary>
        /// seran iguales si tienen el mismo codigo. 
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator == (Cocina c1,Cocina c2)
        {
            bool rta = false;
            if (c1._codigo == c2._codigo)
            {
                rta = true;
            }
            return rta;

        }

        public static bool operator != (Cocina c1, Cocina c2)
        {

            return !(c1 == c2);
        }


        #endregion


    }
}
