using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_ParaisoFiscal;
//using Entidades_paraiso

namespace ParaisosFiscales_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // eTipoDeCliente cliente =  eTipoDeCliente.EmpresarioCorrupto;
            Console.Title = "Arismendy_Herik";

            Cliente mauri = new Cliente(eTipoDeCliente.PoliticoCorrupto, "Mauri");
            Cliente fariña = new Cliente(eTipoDeCliente.Financista, "Fariña");
            Cliente mesias = new Cliente(eTipoDeCliente.JugadordeFutbol, "Lio");

            Console.WriteLine("{0}", Cliente.RetornarDatos(mauri));

            Console.WriteLine("{0}", Cliente.RetornarDatos(fariña));
            Console.WriteLine("{0}", Cliente.RetornarDatos(mesias));
            Console.ReadLine();
        }
    }
}
