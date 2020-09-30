using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_lavadero
{
    public class Lavadero
    {
        #region ATRIBUTOS

        //public List<Vehiculo> Vehiculo;
        public List<Vehiculo> Vehiculo;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        #endregion

        #region PROPIEDADES

        /// <summary>
        /// propiedad de lectura que muestra los precios de cada lavada y la informacion de los vehiculos contenidos. 
        /// </summary>
        public string lavadero
        { get
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("             ***** LISTA DE VEHICULOS *****\n");


                foreach (Vehiculo item in this.Vehiculo)
                {
                    if (item is Moto) // comparo si el item de la lista es de tipo clase MOTO
                    {
                        sb.AppendLine(((Moto)item).mostrarMoto()); // casteo el item que devuelve la lista en un objeto de tipo MOTO
                    }

                    if (item is Camion)
                    {
                        sb.Append(((Camion)item).mostrarCamion());
                    }

                    if (item is Auto)
                    {
                        sb.AppendLine(((Auto)item).mostrarAuto());
                    }
                }

                sb.AppendFormat("\nPrecio Auto : {0}", this.precioAuto);
                sb.AppendLine();

                sb.AppendFormat("\nPrecio Camion: {0}", this.precioCamion);
                sb.AppendLine();

                sb.AppendFormat("\nPrecio moto: {0}", this.precioMoto);

                sb.AppendLine();

                return sb.ToString();
            }
        }



        /// <summary>
        /// Propiedad que retorna la lista de vehiculos. 
        /// </summary>
        public List<Vehiculo> vehiculo
        {
            get { return this.Vehiculo; }
        }

        #endregion

        #region METODOS 

        /// <summary>
        /// Devolvera la ganancia total del lavadero
        /// </summary>
        /// <returns></returns>
        public double MostrarTotalFacturado()
        {
            double ganAuto = 0;
            double ganCamio = 0;
            double ganMoto = 0;
            double ganTotal = 0;

            foreach (Vehiculo item in this.vehiculo)
            {
                if (item is Moto)
                {
                    ganMoto += this.precioMoto;
                    //ganTotal+= this.precioMoto;
                }

                if (item is Camion)
                {
                    ganCamio += this.precioCamion;
                    //ganTotal += this.precioMoto;
                }

                if (item is Auto)
                {
                    ganAuto += this.precioAuto;
                    // ganTotal += this.precioMoto;
                }
            }
            ganTotal = ganMoto + ganCamio + ganAuto;
            return ganTotal;
        }

        /// <summary>
        ///  SOBRECARGA, Muestra el total facturado de cierto tipo de vehiculos
        /// </summary>
        /// <param name="vhc"></param>
        /// <returns></returns>
        public double MostrarTotalFacturado(eVehiculos vhc)
        {
            double ganAuto = 0;
            double ganCamio = 0;
            double ganMoto = 0;
            double ganTotal = 0;

            foreach (Vehiculo item in this.vehiculo)
            {
                if (item is Moto)
                {
                    ganMoto += this.precioMoto;

                }

                if (item is Camion)
                {
                    ganCamio += this.precioCamion;
                    //ganTotal += this.precioMoto;
                }

                if (item is Auto)
                {
                    ganAuto += this.precioAuto;

                }
            }
            //ganTotal = ganMoto + ganCamio + ganAuto;
            switch (vhc)
            {
                case eVehiculos.Moto:
                    ganTotal = ganMoto;
                    break;
                case eVehiculos.Camion:
                    ganTotal = ganCamio;
                    break;
                case eVehiculos.Auto:
                    ganTotal = ganAuto;
                    break;
            }
            return ganTotal;
        }

        #endregion

        #region ORDENAMIENTO

        /// <summary>
        /// Criterio ESTATICO  de ordenamiento por patente.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static int OrdernarPorPatenteAsc(Vehiculo v1, Vehiculo v2)
        {
            return String.Compare(v1.getPatente, v2.getPatente);
        }

        /// <summary>
        /// Criterio DE INSTANCIA  de ordenamiento por patente.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public int OrdenarPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return String.Compare(v1.getMarca.ToString(), v2.getMarca.ToString());
        }

        #endregion

        #region CONSTRUCTOR 

        /// <summary>
        /// Constructor que inicializa la lista de vehiculos 
        /// </summary>
        private Lavadero()
        {
            this.Vehiculo = new List<Vehiculo>();
        }

        public Lavadero(float pAuto, float pCamion, float pMoto) : this()
        {
            this.precioAuto = pAuto;
            this.precioCamion = pCamion;
            this.precioMoto = pMoto;
        }


        #endregion

        #region SOBRECARGAS

        

        /// <summary>
        ///  Retornara TRUE si el vehiculo esta dentro del lavadero 
        ///  FALSE en caso contrario.
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static bool operator == (Lavadero lv , Vehiculo v1)
        {
            bool retorno = false;
            foreach (Vehiculo item in lv.Vehiculo)
            {
                if (item == v1)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        
       public static bool operator !=(Lavadero lv, Vehiculo v1)
        {
            return !(lv == v1);
        }

        /// <summary>
        /// Agrega el vehiculo a la lista del lavadero SIEMPRE Y CUANDO este no exista ya en la lista. 
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static Lavadero operator + (Lavadero lv, Vehiculo v1)
        {
            if (lv != v1)
            {
                lv.vehiculo.Add(v1);
                Console.WriteLine("SE AGREGO !!!");
            }
            else { Console.WriteLine(" NO SE AGREGO, YA EXISTE  !!!"); }
            return lv;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static Lavadero operator - (Lavadero lv, Vehiculo v1)
        {
            if(lv == v1)
            {
                
                lv.vehiculo.Remove(v1);
                Console.WriteLine("SE ELIMINO !!!");
            }
            else { Console.WriteLine("NO SE ELIMINO, NO EXISTE  !!!"); }
            return lv;
        }
        #endregion

        #region
        #endregion
    }
}
