using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInterface
{
    public class Familiar : Auto
    {
        #region ATRIBUTOS
        protected int _cantAsientos;
        #endregion

        #region CONSTRUCTORES

        public Familiar ( double prec , string patente, int asientos) : base ( prec,patente)
        {
            this._cantAsientos = asientos;
        }

        #endregion

        #region METODOS

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio Auto familiar : {0}", base._precio);
        }

        public override void MostrarPatente()
        {
            Console.WriteLine("Patente Auto familiar : {0}", base._precio);
        }

        #endregion
    }
}
