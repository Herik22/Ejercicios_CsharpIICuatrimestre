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

            sb.AppendLine();
            sb.AppendFormat("Fecha de inicio de actividades: {0}",fechaInicioActividades);
            sb.AppendLine();

            sb.AppendFormat("Lugar de radicacion: {0}", this.lugar);
            sb.AppendLine();

            sb.AppendFormat("Cantidad de cuentas OffShore : {0}", cantidadDeCuentas);
            sb.AppendLine();

            sb.Append("                 ***** DETALLE DE CUENTAS ******");
            sb.AppendLine();
            Console.WriteLine("{0}", sb.ToString());
            foreach (CuentaOffShore infoCuentas in this.listadoCuentas)
            {
                Console.WriteLine("{0}", Cliente.RetornarDatos(infoCuentas.getDueño()));
                Console.WriteLine("N° de Cuenta : {0}", (int)infoCuentas);
                Console.WriteLine("Saldo : {0}", infoCuentas.getSaldo());
                Console.WriteLine("");

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
            bool retorno = false;
            
            if (pF.listadoCuentas.Contains(cOS)) // mi FORMA DISNEY 
            {
                return true;
            }
            else { return false; }

            /* if (((object)pF) != null && ((object)cOS)!= null)  // como lo hizo el profe y pasaron al grupo de wap 
             {
                 retorno = true; 
             }
             else if (((object)pF) != null && ((object)cOS) != null)
             {
                 if (pF.listadoCuentas.Contains(cOS))
                 {
                     retorno =  true;
                 }
             }
             return retorno;*/
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
                // if(pF.listadoCuentas.Remove(cOF))
                //{
                pF.listadoCuentas.Remove(cOF);
                    ParaisoFiscal.cantidadDeCuentas --;
                    Console.WriteLine("Se quito la cuenta del Paraiso ....");
                    //return pF;
               // }
                
            }
                return pF;
        }

        /// <summary>
        /// permite agregar una cuentaOffShore a la lista de ParaisosFiscales solo si no esta contenida en ella, incrementa en uno la cantidad de cuentas
        /// si la cuenta ya existe en el paraiso fiscal se sumaran los saldos. 
        /// </summary>
        /// <returns></returns>
        public static ParaisoFiscal operator + (ParaisoFiscal pf,CuentaOffShore cOS)
        {
            
            if (! (pf == cOS))
            {
                pf.listadoCuentas.Add(cOS);
                ParaisoFiscal.cantidadDeCuentas++;
                Console.WriteLine("Se agrego la cuenta al Paraiso ....");
                
            }else
            {
                foreach (CuentaOffShore aux in pf.listadoCuentas)
                {

                    double s1 = aux.getSaldo();
                    double s2 = cOS.getSaldo();
                    double s12 = s1 + s2;

                    aux.setSaldo(s12);


                    Console.WriteLine("Se actualizo el saldo de la cuenta  ....");

                }
               /*double aux = cOS.getSaldo 
               cOS.setSaldo( cOS.getSaldo());*/
            }
            return pf;
        }
        #endregion
    }
}