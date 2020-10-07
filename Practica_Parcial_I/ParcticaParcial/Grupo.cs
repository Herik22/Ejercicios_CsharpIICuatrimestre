using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParcticaParcial
{
    public class Grupo
    {
        #region ATRIBUTOS
        private List<Mascota> manada;
        private string nombre;
        private static EtipoManada tipo;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// propiedad de escritura para el tipo de manada.
        /// </summary>
        public EtipoManada Tipo 
        { 
            set
            {
                Grupo.tipo = value;
            }
        }

        #endregion

        #region CONSTRUCTORES

        /// <summary>
        /// de clase, inicializa el tipo en Unica.
        /// </summary>
        static Grupo ()
        {
            Grupo.tipo = EtipoManada.Unica;
        }

        /// <summary>
        /// por defecto inicializa la lista.
        /// </summary>
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        /// <summary>
        /// recibe unicamente el nombre del grupo
        /// </summary>
        /// <param name="name"></param>
        public Grupo (string name):this()
        {
            this.nombre = name;
        }

        /// <summary>
        /// Reibe el nombre y tipo de la manada. 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tipo"></param>
        public Grupo (string name, EtipoManada tipo):this(name)
        {
            Grupo.tipo = tipo;
        }
        #endregion

        #region SOBRECARGAS

        /// <summary>
        /// Conversion que retorna la informacion del grupo.
        /// </summary>
        /// <param name="g"></param>
        public static implicit operator string (Grupo g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Grupo: {0} - tipo: {1}", g.nombre, Grupo.tipo);
            sb.AppendLine();
            sb.AppendFormat("Integrantes: {0}", g.manada.Count);
            sb.AppendLine();
            foreach(Mascota item in g.manada)
            {
                if(item is Perro || item is Gato)
                {
                    sb.AppendLine(item.ToString());
                    sb.AppendLine();
                }
                /*else if (item is Gato)
                {
                    sb.AppendLine(item.ToString());
                    sb.AppendLine();
                }*/
            }

            return sb.ToString();
        }
        /// <summary>
        /// TRUE = La mascota esta dentro del grupo
        /// FALSE = lo contrario.
        /// </summary>
        /// <returns></returns>
        public static bool operator == (Grupo g,Mascota m)
        {
            bool rta = false;

            foreach(Mascota item in g.manada)
            {
                if (m.Equals(item)) // uso del equal, dependiendo de la mascota ira al determinado equals; si son iguales esta en la lista.
                {
                    rta = true;
                }
            }
            return rta;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        /// <summary>
        /// si la mascota NO forma parte de la lista se podra agregar 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static Grupo operator + (Grupo g, Mascota m)
        {
            if( g != m) // NO pertenece a la lista 
            {
                g.manada.Add(m);
                return g;
            }else
            {
                Console.WriteLine("Ya esta, {0} en el grupo.",m.ToString());
            }
            return g;
        }

        /// <summary>
        /// Si la mascota ESTA en la lista se quitara de ella. 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static Grupo operator - (Grupo g, Mascota m)
        {
            if(g == m)
            {
                g.manada.Remove(m);
            }
            else
            {
                Console.WriteLine("NO esta el {0} en el grupo.", m.ToString());
            }
            return g;
        }
        #endregion
    }
}
