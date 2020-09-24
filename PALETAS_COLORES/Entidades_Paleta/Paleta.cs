using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Paleta
{
    
    class Paleta
    {
        #region ATRIBUTOS
        
        private Tempera[] temperast;
        private int cantidadMaxima;

        #endregion

        #region METODOS 

        /// <summary>
        /// Genera el esquema para mostrar la informacion de la Paleta  accede a sus campos PRIVADOS.
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
             string most = " Temperas Vacias. ";
            StringBuilder sb = new StringBuilder();
            for (int i =0; i<this.temperast.Length;i++)
            {
                most =  Tempera.Mostrar(temperast[i]);
            }
            return most;
        }

        /// <summary>
        /// Recorre el array de temperas y devulve una posicion libre para usar. 
        /// </summary>
        /// <returns></returns>
        public  int obtenerIndice()
        {
            int retorno = -1;
            for ( int i=0;i<this.temperast.Length;i++)
            {
                if( this.temperast[i] == null)
                {
                    retorno =  i;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Recorre el array de temperas y retorna la posicion en la que se encuentra el parametro recibido.
        /// </summary>
        /// <param name="t1"></param>
        /// <returns></returns>
        public int obtenerIndice (Tempera t1)
        {
            int retorno = -1;
            for (int i = 0; i < this.temperast.Length; i++)
            {
                if (this.temperast[i] == t1)
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }



        #endregion

        #region SOBRECARGAS

        public static implicit operator Paleta (int cantidadmaxima)
        {
            return new Paleta(cantidadmaxima);
        }

        public static explicit operator string (Paleta p1)
        {          
              return p1.Mostrar(); 
        }

        /// <summary>
        /// Compara y devuelve si la tempera que recibe esta en la paleta. 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="t1"></param>
        /// <returns></returns>
        public static bool operator == (Paleta p1, Tempera t1)
        {
            for ( int i=0;i<p1.temperast.Length;i++)
            {
                if(p1.temperast[i] == t1 )
                {
                    return true;
                    
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga opuesta al operador == 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="t1"></param>
        /// <returns></returns>
        public static bool operator != (Paleta p1, Tempera t1)
        {
            return !(p1 == t1);
        }

        public static Paleta operator + (Paleta p1, Tempera t1)
        {
            int indice = p1.obtenerIndice(t1);
            
            if( indice != -1)
            {
                Tempera retorno = t1 + 1;

                p1.temperast[indice] = retorno;
                return p1;
            }
            else
            {
                p1.temperast[indice] = t1;
                return p1;
            }
        }

        public static Paleta operator - (Paleta p1, Tempera t1)
        {
            // Tempera retorno;
            int indice = p1.obtenerIndice(t1);

            if (indice != -1)
            {
                Tempera retorno = t1 - 1;
                p1.temperast[indice] = retorno;

                if( retorno == 0)
                {
                    p1.temperast[indice] = null;                  
                }
                return p1;
            }
            return p1;
        }

        public static Paleta operator + (Paleta p1,Paleta p2)
        {
            int indice = p1.obtenerIndice();
            for (int i=0;i<p1.temperast.Length ; i++)
            {
                for (int j=0;j<p2.temperast.Length; j++)
                {
                    if(p1.temperast[i] != p2.temperast[j])
                    {
                        p1.temperast[indice] = p2.temperast[j]; // agrego la tempera a la paleta 

                    }else
                    {
                        p1.temperast[i] = p1.temperast[i] + p2.temperast[j];
                    }
                }
            }
            return p1;
        }
            #endregion

        #region CONSTRUCTORES
        public Paleta ()
        {
            this.temperast = new Tempera[5];

        }

        public Paleta(int cantMaxColores)
        {
            this.cantidadMaxima = cantMaxColores;
        }
#endregion
    }
}
