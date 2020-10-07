using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arismendy.Herik._2A
{
    public abstract class Vehiculo
    {
        #region ATRIBUTOS

        protected Fabricante fabricante;
        protected static Random generadorDeVelocidades;
        protected string modelo;
        protected float precio;
        protected int velocidadMaxima;

        #endregion

        #region PROPIEDADES

        public int VelocidadMaxima
        {  
            get 
            {
                if (this.velocidadMaxima == 0)
                {
                    this.velocidadMaxima = Vehiculo.generadorDeVelocidades.Next(100, 280);                  
                }
                return this.velocidadMaxima;
            }
        }

        #endregion

        #region CONSTRUCTORES

        static Vehiculo ()
        {

        }

        public Vehiculo (float precio,string modelo,Fabricante fabri)
        {
            this.precio = precio;
            this.modelo = modelo;
            this.fabricante = fabri;
        }

        public Vehiculo(string marca,EPais pais,string modelo,float precio):this(precio,modelo,new Fabricante(marca,pais))
        {

        }
        #endregion

        #region METODOS

        private static string Mostrar (Vehiculo v)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendFormat(" Fabricante : {0}", (string)v.fabricante);
            sb.AppendLine();
            sb.AppendFormat("Modelo : {0}", v.modelo);
            sb.AppendLine();
            sb.AppendFormat("Velocidad Max : {0}", v.velocidadMaxima);

            return sb.ToString();
        }


        #endregion

        #region SOBRECARGAS

        public static explicit operator string (Vehiculo v)
        {
            return Vehiculo.Mostrar(v);
        }

        public static bool operator == (Vehiculo a, Vehiculo b)
        {
            bool retorno = false;
            // igualdad en modelo y fabricante 
            if ( a.modelo == b.modelo && a.fabricante == b.fabricante)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator != (Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }
        #endregion
    }
}
