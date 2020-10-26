using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    
    public class DepositoDeAutos
    {
        #region ATRIBUTOS

        protected int _capacidadMaxima;
        protected List<Auto> _lista;

        #endregion

        #region CONSTRUCTORES

        public DepositoDeAutos (int capacidad)
        {
            this._capacidadMaxima = capacidad;
            _lista = new List<Auto>();
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Retornara el indice en el que se encuentra el auto recibido. si la lista no existe retorna -1.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private int GetIndice (Auto a)
        {
            int rta = -1;
            if(this._lista.Count > 0 )
            {
                rta = this._lista.IndexOf(a);          
            }
            return rta;
        }
        /// <summary>
        /// Hace uso de la sobrecarga + para agregar un auto
        /// </summary>
        /// <param name="a1"></param>
        /// <returns></returns>
        public bool Agregar (Auto a1)
        {
            bool rta = false;
            if (this + a1)
            {
                rta = true;
            }
            return rta;
        }

        /// <summary>
        /// Hace uso de la sobrecarga - para eliminar  un auto
        /// </summary>
        /// <param name="a1"></param>
        /// <returns></returns>
        public bool Remover (Auto a1)
        {
            bool rta = false;
            if(this - a1)
            {
                rta = true;
            }
            return rta;
        }
        /// <summary>
        ///  permite retornar la informacion del deposito de autos. (capacidad y detalle de los autos.)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad Maxima: {0}", _capacidadMaxima);
            sb.AppendLine();
            sb.AppendLine("                     LISTA DE VEHICULOS ");
            foreach (Auto item in this._lista)
            {
                
                sb.AppendLine(item.ToString());

            }
            return sb.ToString();
        }
        #endregion

        #region SOBRECARGAS

        /// <summary>
        /// Permite agregar un auto a la lista de autos. 
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator + (DepositoDeAutos dA1, Auto a1)
        {
            bool rta = false;
            if ( dA1._capacidadMaxima > dA1._lista.Count )
            {
                dA1._lista.Add(a1);
                //Console.WriteLine("Se agrego el auto !");
                rta = true;
            }
            return rta;
        }
        /// <summary>
        /// Permite eliminar un auto de la lista. 
        /// </summary>
        /// <param name="dA1"></param>
        /// <param name="a1"></param>
        /// <returns></returns>
        public static bool operator - (DepositoDeAutos dA1, Auto a1)
        {
            bool rta = false;
            int indice = dA1.GetIndice(a1);
            if(indice != -1)
            {
                dA1._lista.RemoveAt(indice);
                rta = true;
            }
            return rta;
        }

        #endregion
    }
}
