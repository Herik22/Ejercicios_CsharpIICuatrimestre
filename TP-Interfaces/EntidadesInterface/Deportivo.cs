using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInterface
{
    public class Deportivo : Auto, IAFIP
    {
        #region ATRIBUTOS 

        protected int caballosDeFuerza;

        #endregion

        #region CONSTRUCTORES

        public Deportivo (double prec, string patente,int cabFuerza) : base (prec,patente)
        {
            this.caballosDeFuerza = cabFuerza;
        }

        #endregion

        #region METODOS

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio Auto Deportivo : {0}", base._precio);
        }

        public override void MostrarPatente()
        {
            Console.WriteLine("Patente Auto Deportivo : {0}", base._precio);
        }

        #endregion

        #region IMPLEMENTACION IAFIP

        public double CalcularImpuesto () //28%
        {
            return base._precio * 28 / 100;
        }

        #endregion
    }
}
