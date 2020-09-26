using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_ParaisoFiscal
{
    public class ParaisoFiscal
    {
        #region ATRIBUTOS

        private List<CuentaOffShore> listadoCuentas;
        private eParaisosFiscales lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicioActividades;

        #endregion

        #region METODOS

        public void mostrarParaiso ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Fecha de inicio de actividades: {0}",fechaInicioActividades);
            sb.AppendLine();

            sb.AppendFormat("Lugar de radicacion: {0}", this.lugar);
            sb.AppendLine();

            sb.AppendFormat("Cantidad de cuentas OffShore : {0}", cantidadDeCuentas);
            sb.AppendLine();

            sb.Append("                 ***** DETALLE DE CUENTAS ******");
            sb.AppendLine();
            foreach (CuentaOffShore infoCuentas in this.listadoCuentas)
            {
                Console.WriteLine("{0}", Cliente.RetornarDatos(infoCuentas.getDueño()));
            }           
        }

        #endregion

        #region CONSTRUCTORES
      
        static ParaisoFiscal() // no debe llevar modificador de acceso y solo inicializa los campos ESTATICOS
        {
            cantidadDeCuentas = 0;
            fechaInicioActividades = DateTime.Now;
        }

        private ParaisoFiscal()
        {
            this.listadoCuentas = new List<CuentaOffShore>();
        }

        private ParaisoFiscal(eParaisosFiscales lugarr) : this()
        {
            this.lugar = lugarr;
        }

        #endregion

        #region SOBRECARGAS

        /// <summary>
        /// Recibe un enumerado de Paraisos Fiscales y retorna un objeto de tipo Paraiso Fiscal 
        /// </summary>
        /// <param name="epf"></param>
        public static implicit operator ParaisoFiscal (eParaisosFiscales epf)
        {
            return new ParaisoFiscal(epf);
        }
        /// <summary>
        /// Retornara TRUE = si la cuenta OffShore existe en el Paraiso Fiscal
        /// FALSE = Caso contrario.
        /// </summary>
        /// <returns></returns>
        public static bool operator == (ParaisoFiscal pF,CuentaOffShore cOS)
        {
            // en paraiso fiscal tengo una lista de objetos tipo CUENTAOFFSHORE la recorro y comparo con la cuenta recibida
            foreach (CuentaOffShore auxCOS in pF.listadoCuentas)
            {
                if(auxCOS == cOS)
                {
                    return true; 
                }
            }         
            return false;
        }

        /// <summary>
        /// Sobrecarga contraria al == De paraiso fiscal y cuentaOffShore 
        /// </summary>
        /// <param name="pF"></param>
        /// <param name="cOS"></param>
        /// <returns></returns>
        public static bool operator != (ParaisoFiscal pF, CuentaOffShore cOS)
        {
            return !(pF == cOS);
        }

        /// <summary>
        /// permite eliminar una cuentaOffShore a la lista de cuentas de la misma si es que se encuentraen el paraiso fiscal
        /// decrementa en 1 la cantidad de cuentas si se pudo quitar la cuenta.
        /// </summary>
        /// <param name="pF"></param>
        /// <param name="cOF"></param>
        /// <returns></returns>
        public static ParaisoFiscal operator - (ParaisoFiscal pF , CuentaOffShore cOF)
        {
            if ( pF == cOF)
            {
                if(pF.listadoCuentas.Remove(cOF))
                {
                   int q = ParaisoFiscal.cantidadDeCuentas -= 1;
                    return pF;
                }
                
            }
                return pF;
        }

        public static ParaisoFiscal operator + ()
        #endregion
    }
}
