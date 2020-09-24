using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Paleta
{
    public class Tempera
    {
        #region ATRIBUTOS 
        private ConsoleColor color;
        private string marca;
        private int cantidad;
        #endregion

        #region METODOS
        /// <summary>
        /// Genera el esquema para mostrar la informacion de la tempera  accede a sus campos PRIVADOS.
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Color:");
            sb.AppendLine(this.color.ToString());
            sb.AppendFormat("marca {0}", this.marca);
            sb.AppendLine();
            sb.Append("Cantidad:");
            sb.AppendLine(this.cantidad.ToString());
            sb.AppendLine();

            return sb.ToString();
        } // de instancia ya que no tiene la palabra static, se debe INSTANCIAR un objeto para su uso 

        /// <summary>
        ///  Muestra los datos de la tempera recibida por parametro. 
        /// </summary>
        /// <returns></returns>
        public static string Mostrar(Tempera t1) // De clase ya que tiene la palabra static, se accede por medio de la clase. 
        {
            //  t1 = new Tempera();
            return t1.Mostrar();
        }

        #endregion

        #region SOBRECARGA DE OPERADORES 

        /// <summary>
        /// Sobrecarga del operador == que compara por color y marca. 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator ==(Tempera t1, Tempera t2)   // marca y color 
        {
            bool rta = false;
            if (t1.color == t2.color && t1.marca == t2.marca)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        /// <summary>
        /// Hace una asignacion IMPLICITA  de un entero a un objeto de tipo tempera
        /// </summary>
        /// <param name="cantidadd"></param>
        public static implicit operator int  ( Tempera t1 ) // int   "cosas = otracosaimplicitamente ->  CONVERSION IMPLICITA"
        {
            return t1.cantidad;
        }

        /// <summary>
        /// Si los colores son iguales agrega uno a la cantidad 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static Tempera operator + (Tempera t1, Tempera t2)
        {
            if(t1 == t2)
            {
                t1.cantidad  += 1;//Tempera returnn = new Tempera(+1);
                t1.color = t2.color;
                t1.marca = t2.marca;
                return t1;
            }
            return t1;
        }

        public static Tempera operator - (Tempera t1, int numero )
        {
           
            t1.cantidad = t1.cantidad - numero;
            return t1;
        }

        public static bool operator == (Tempera t1 , int cantidad)
        {
            if ( t1.cantidad <= cantidad)
            {
                return true;
            }
            return false;
        }

        public static bool operator != (Tempera t1, int cantidad)
        {
            return !(t1 == cantidad);
        }

        /// <summary>
        /// Suma  una cantidad recibida como parametro a la cantidad de esa tempera. 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static Tempera operator + (Tempera t1, int cantida )
        {
            if (t1.cantidad != cantida)
            {
                t1 += cantida;             
                return t1;
            }
            return t1;
        }

        #endregion

        #region CONSTRUCTORES

        public Tempera(ConsoleColor c1,string m1,int cant1)
        {
            this.color = c1;
            this.marca = m1;
            this.cantidad = cant1;
        }

        public Tempera( int cant1)
        {
            this.cantidad = cant1;
        }
        #endregion


    }
}
