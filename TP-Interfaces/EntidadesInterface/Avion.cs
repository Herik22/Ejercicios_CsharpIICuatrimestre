using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInterface
{
    public class Avion : Vehiculo, IAFIP 
    {
        #region ATRIBUTOS 

        double velocidadMaxima;

        #endregion

        #region CONSTRUCTORES

        public Avion (double precio,double velocidadM): base (precio)
        {
            this.velocidadMaxima = velocidadM;
        }
        #endregion

        #region METODOS 

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio Avion: {0}", base._precio);
        }

        #endregion

        #region IMPLEMENTACION IAFIP

        public double CalcularImpuesto()
        {
            return base._precio * 33 / 100;
        }

        #endregion
    }
}
