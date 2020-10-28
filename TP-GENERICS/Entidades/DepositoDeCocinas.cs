using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        #region ATRIBUTOS

        private  int _capacidadMaxima;
        private List<Cocina> _lista;

        #endregion

        #region CONSTRUCTORES

        public DepositoDeCocinas (int capacidad)
        {
            this._capacidadMaxima = capacidad;
            _lista = new List<Cocina>();
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Retornara el indice en el que se encuentra el auto recibido. si la lista no existe retorna -1.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private int GetIndice(Cocina a)
        {
            int rta = -1;
            if (this._lista.Count > 0)
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
        public bool Agregar(Cocina c1)
        {
           
            return this + c1;
        }

        /// <summary>
        /// Hace uso de la sobrecarga - para eliminar  un auto
        /// </summary>
        /// <param name="a1"></param>
        /// <returns></returns>
        public bool Remover(Cocina c1)
        {
            return this - c1;
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
            sb.AppendLine("LISTA DE COCINAS ");
            foreach (Cocina item in this._lista)
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
        public static bool operator + (DepositoDeCocinas dC1, Cocina c1)
        {
            bool rta = false;
            if (dC1._capacidadMaxima > dC1._lista.Count)
            {
                dC1._lista.Add(c1);
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
        public static bool operator - (DepositoDeCocinas dC1, Cocina c1)
        {
            bool rta = false;
            int indice = dC1.GetIndice(c1);
            if (indice != -1)
            {
                dC1._lista.RemoveAt(indice);
                rta = true;
            }
            return rta;
        }

        #endregion
    }
}
