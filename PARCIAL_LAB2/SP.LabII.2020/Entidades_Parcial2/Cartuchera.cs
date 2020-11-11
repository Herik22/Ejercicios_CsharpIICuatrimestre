using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Parcial2
{
    /// <summary>
    /// Clase generica que solo podra contener clases de tipo Utiles
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Cartuchera<T> where T : Utiles
    {
        #region ATRIBUTOS
        protected int capacidad;
        protected List<T> elementos;

        #region DELEGADO - EVENTO
        /// <summary>
        /// Delegado asociado al manejador de eventos con su firma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void DelegadoLimitePrecio(Object sender, EventArgs e);
        /// <summary>
        /// Evento que sera lanzado cuando se sobrepase el limite de precio total 
        /// </summary>
        public event DelegadoLimitePrecio EventoPrecio;
        #endregion

        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de solo lectura que expone el atributo de tipo lista. 
        /// </summary>
        public List<T> Elementos { get { return this.elementos; } }

        /// <summary>
        /// propiedad de solo lectura que retorna el precio total de los elementos en la cartuchera. 
        /// </summary>
        public double PrecioTotal
        {

            get
            {
                double retorno = 0;
                foreach (T item in this.elementos)
                {
                    retorno += item.precio;
                }
                return retorno;
            }
        }
        #endregion

        #region CONTRUCTORES

        /// <summary>
        /// constructor por default, el cual se encargará de inicializar la lista.
        /// </summary>
        public Cartuchera()
        {
            this.elementos = new List<T>();
        }

        /// <summary>
        /// Constructor parametrizado que reutiliza el por defecto. 
        /// </summary>
        /// <param name="capacidad_"></param>
        public Cartuchera(int capacidad_) : this()
        {
            this.capacidad = capacidad_;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Metodo que hara publica toda la informacion de la cartuchera. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendFormat("Tipo de Cartuchera: {0}", typeof(T).Name);
            sb.AppendLine();
            sb.AppendFormat("Cantidad de Elementos: {0}", this.elementos.Count());
            sb.AppendLine();
            sb.AppendFormat("Precio Total: {0}", this.PrecioTotal);
            sb.AppendLine("Lista de elementos.");
            foreach (T item in this.elementos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        #endregion

        #region SOBRECARGAS
        /// <summary>
        /// agregara el elemento a la lista siempre y cuando no se sobrepase la capacidad de la misma.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public static Cartuchera<T> operator +(Cartuchera<T> c1, T elemento)
        {
            if (c1.capacidad > c1.elementos.Count && c1 != null)
            {
                c1.elementos.Add(elemento);
            }
            else
            {
                throw new CartucheraLlenaException();
            }
            if (c1.PrecioTotal > 85 && c1.EventoPrecio != null) //si el preco total es mayor a 85 lanzo el evento 
            {
                c1.EventoPrecio.Invoke(c1, EventArgs.Empty);
            }
            return c1;
        }
        #endregion
    }
}
