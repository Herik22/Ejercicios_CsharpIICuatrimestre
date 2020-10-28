using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInterface
{
    public class Carreta : Vehiculo
    {
        #region CONSTRUCTORES

        public Carreta (double precio) : base(precio)
        {

        }

        #endregion

        #region METODOS

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio carreta : {0}",base._precio);
        }

        #endregion
    }
}
