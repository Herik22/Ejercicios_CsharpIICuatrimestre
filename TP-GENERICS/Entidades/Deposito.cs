using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T> // clase generica de tipo T
    {
        #region ATRIBUTOS

        private int _capacidadMaxima;
        private List<T> _lista;

        #endregion

        #region CONSTRUCTOR 

        public Deposito (int capacidad )
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        #endregion

        #region METODOS

        private int GetIndice(T a)
        {
            int rta = -1;
            if (this._lista.Count > 0)
            {
                rta = this._lista.IndexOf(a);
            }
            return rta;
        }

        public bool Agregar(T t1)
        {
            return this + t1;
        }

        public bool Remover(T t1)
        {
            return this - t1;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CAPACIDAD MAX: {0}", this._capacidadMaxima);
            sb.AppendLine();
            foreach (T item in this._lista)
            {
                
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        #endregion

        #region SOBRECARGAS

        public static bool operator +(Deposito<T> dT, T t1)
        {
            bool rta = false;
            if (dT._capacidadMaxima > dT._lista.Count)
            {
                dT._lista.Add(t1);
                rta = true;
            }
            return rta;
        }

        public static bool operator -(Deposito<T> dT, T t1)
        {
            bool rta = false;
            int index = dT.GetIndice(t1);
            if (index != -1)
            {
                dT._lista.RemoveAt(index);
                rta = true;
            }
            return rta;
        }
        #endregion
    }    
}
