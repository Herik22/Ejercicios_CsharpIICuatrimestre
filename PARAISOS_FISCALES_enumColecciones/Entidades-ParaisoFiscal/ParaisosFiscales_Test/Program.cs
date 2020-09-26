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

            // instancio objetos de tipo cliente
            Cliente mauri = new Cliente(eTipoDeCliente.PoliticoCorrupto, "Mauri");
            Cliente fariña = new Cliente(eTipoDeCliente.Financista, "Fariña");
            Cliente mesias = new Cliente(eTipoDeCliente.JugadordeFutbol, "Lio");

            // instancios objetos de tipo CUENTAOFFSHORE 
            CuentaOffShore messiOff = new CuentaOffShore(mesias, 123, 15000);
            CuentaOffShore mauriOff = new CuentaOffShore(mauri, 678, 25000);
            CuentaOffShore lazaroOff = new CuentaOffShore("Lazaro", eTipoDeCliente.EmpresarioCorrupto, 456, 56000);
            CuentaOffShore otraMauri = new CuentaOffShore(mauri, 678, 50000);
            CuentaOffShore fariOff = new CuentaOffShore(fariña, 666, 3500);

            ParaisoFiscal panamaPapers = eParaisosFiscales.Panama;

            // si la cuenta no existe deberia agregarla a la lista, si existe suma los saldos.
            panamaPapers += messiOff;
            panamaPapers += mauriOff;
            panamaPapers += lazaroOff;

            panamaPapers.mostrarParaiso();

            Console.ReadLine();
            panamaPapers += otraMauri;
            // si la cuenta esta en el paraiso fiscal la eliminara. de ser posible tambien disminuye la cantidad de cuentas.
            panamaPapers -= messiOff;
            panamaPapers -= fariOff;

            panamaPapers.mostrarParaiso();

            Console.ReadLine();

            
        }
    }
}
