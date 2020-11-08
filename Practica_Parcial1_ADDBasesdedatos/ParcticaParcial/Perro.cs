using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParcticaParcial
{
    /// <summary>
    /// Clase derivada de Mascota
    /// </summary>
    public class Perro : Mascota
    {
        #region ATRIBUTOS

        public  int edad; // cambiar a private !!!!!
        private bool esAlfa;

        #endregion // atributos constructores propiedades metodos y sobrecargas 

        #region CONSTRUCTOR

        public Perro (string name,string raza) : base(name,raza)
        {
            this.edad = 0;
            this.esAlfa = false;

        }

        public Perro (string name, string raza, int edad, bool isAlfa):this(name,raza)
        {
            this.edad = edad;
            this.esAlfa = isAlfa;
        }

        #endregion

        #region METODOS 

        /// <summary>
        /// REESCRITO -- permite comparar diferentes objetos. 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool rta = false;     
            
            if( obj is Perro) // confirmo que sea de tipo "Perro"
            {
                rta = this == (Perro)obj; // hago uso del == 
            }

            return rta;
        }

        /// <summary>
        /// Sobre escritutra que muestras toda la informacion del perro.
        /// </summary>
        /// <returns></returns>
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
           // sb.AppendLine();
            sb.Append("Perro - ");
            sb.AppendFormat(base.DatosCompletos());
            if(this.esAlfa)
            {
                sb.Append("- Alfa de la manada");
            }         
             sb.AppendFormat("- edad {0}' ", this.edad);
            
            
            
            return sb.ToString();
        }

        /// <summary>
        /// Retorna la ficha del perro
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Ficha() ;
        }
        #endregion

        #region SOBRECARGAS

        /// <summary>
        /// conversion que retorna la edad del perro
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator int (Perro p)
        {
            return p.edad;
        }

        /// <summary>
        ///  TRUE = seran iguales si comparten Nombre,Raza,Edad
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator == (Perro p1, Perro p2)
        {
            bool rta = false;
            if ( (Mascota)p1 == (Mascota)p2  &&  p1.edad == p2.edad )
            {
                rta = true;
            }
            return rta;


        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }
        #endregion
    }
}
