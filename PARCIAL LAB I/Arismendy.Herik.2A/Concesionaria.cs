using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik._2A
{
    public class Concesionaria
    {
        #region ATRIBUTOS

        private int capacidad;
        private List<Vehiculo> vehiculos;

        #endregion

        #region PROPIEDADES

        public double PrecioDeAutos 
        {
            get
            {
                double precioDeAutos = 0;
                foreach (Vehiculo item in this.vehiculos)
                {
                    if(item is Auto)
                    {
                        precioDeAutos += (Single)(Auto)item;
                    }
                }
                return precioDeAutos;
            }
        }

        public double PrecioDeMotos
        {
            get
            {
                double precioDeMotos = 0;
                foreach (Vehiculo item in this.vehiculos)
                {
                    if (item is Moto)
                    {
                        precioDeMotos += (Single)(Moto)item;
                    }
                }
                return precioDeMotos;
            }
        }

        public double PrecioTotal
        {
            get 
            {
                return this.PrecioDeAutos + this.PrecioDeMotos;
            }
        }

        #endregion

        #region CONSTRUCTORES

        private Concesionaria()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        private Concesionaria (int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        #endregion

        #region METODOS

        public static string Mostrar(Concesionaria c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendFormat("Total Auto: {0:n} ", c.ObtenerPrecio(EVehiculo.PrecioDeAutos));
            sb.AppendLine();
            sb.AppendFormat("Total Moto: {0:n} ", c.ObtenerPrecio(EVehiculo.PrecioDeMotos));
            sb.AppendLine();
            sb.AppendFormat("Total Facturado: {0:n} ", c.ObtenerPrecio(EVehiculo.PrecioTotal));
            sb.AppendLine();
            sb.AppendFormat("Capacidad {0}", c.capacidad);
            sb.AppendLine();
            sb.AppendLine("************************************");
            sb.AppendLine( "LISTADO DE VEHICULOS");
            sb.AppendLine("************************************");
            foreach (Vehiculo item in c.vehiculos)
            {
                if (item is Auto || item is Moto)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }

         private double ObtenerPrecio (EVehiculo tipoVehiculo)
         {
            double retorno = 0;
            
             switch (tipoVehiculo)
            {
                case EVehiculo.PrecioDeAutos:
                    retorno = PrecioDeAutos;
                    break;

                case EVehiculo.PrecioDeMotos:
                    retorno = PrecioDeMotos;
                    break;

                case EVehiculo.PrecioTotal:
                    retorno = PrecioTotal;
                    break;
            }
            return retorno;
         }


        #endregion

        #region SOBRECARGAS

        public static implicit operator Concesionaria (int  capacidad)
        {
            return new Concesionaria(capacidad);
        }

        public static bool operator == (Concesionaria c, Vehiculo v)
        {
            bool retorno = false;
            // igualdad si vehiculo esta en la lista 
            foreach(Vehiculo item in c.vehiculos)
            {
               if ( v.Equals(item) )
                    {
                        retorno = true;
                    }
            }
            return retorno;
        }

        public static bool operator != (Concesionaria c, Vehiculo v)
        {
            return !(c == v);
        }

        public static Concesionaria operator + (Concesionaria c, Vehiculo v)
        {
            // adiciona si la cocnecionaria posee capacidad y dicho vehiculo NO!! esta en la lista,SINO INFORMAR
            if(  c.vehiculos.Count < c.capacidad)
            {
                if (c != v)
                {
                    c.vehiculos.Add(v);
                }else { Console.WriteLine("El vehiculo ya esta en la concecionaia !!!\n"); }
            }
            else { Console.WriteLine("No hay mas lugar  en la concecionaia !!!\n"); }
            return c;
        }
        
        #endregion
    }
}
