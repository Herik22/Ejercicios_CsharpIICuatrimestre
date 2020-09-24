using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_ParaisoFiscal
{
    public class CuentaOffShore
    {
        #region ATRIBUTOS 

        private  Cliente dueño;
        private int numeroCuenta;
        private double saldo;

        #endregion

        #region PROPIEDADES

        public Cliente getDueño ()
        {
            return this.dueño;
        }

        public double getSaldo ()
        {
            return this.saldo;    
        }

        public void setSaldo (double valor )
        {
            this.saldo = valor;
        }
        #endregion

        #region METODOS
        #endregion

        #region CONSTRUCTORES 

        /// <summary>
        /// Consturctor de cuenta que recibe todos los campos.
        /// </summary>
        /// <param name="dueño"></param>
        /// <param name="numero"></param>
        /// <param name="saldo"></param>
        public CuentaOffShore(Cliente dueño, int numero, double saldo)
        {
            this.dueño = dueño;
            this.numeroCuenta = numero;
            this.saldo = saldo;
        }

        /// <summary>
        /// Constructor de cuenta que a parte de recibir los campos de la cuenta, recibe el tipo de CLIENTE.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tipoCliente"></param>
        /// <param name="numero"></param>
        /// <param name="saldoInicial"></param>
        public CuentaOffShore (String nombre,eTipoDeCliente tipoCliente,int numero,double saldoInicial):this(new Cliente(tipoCliente), numero,saldoInicial)
        {
            //this.dueño = new Cliente(tipoCliente);
        }

        #endregion

        #region SOBRECARGAS 


        /// <summary>
        /// Conversion explicita que retorna el numero de la cuenta.
        /// </summary>
        /// <param name="cOS"></param>
        public static explicit operator int (CuentaOffShore cOS)
        {
            return cOS.numeroCuenta;
        }

        /// <summary>
        /// Retornara TRUE: si ambas cuentas pertenecen al mismo DUEÑO (ALIAS) y poseen el mismo NUMERO DE CUENTA.
        /// FALSE: Caso contrario
        /// </summary>
        /// <param name="cOS"></param>
        /// <param name="cOS2"></param>
        /// <returns></returns>
        public static bool operator == ( CuentaOffShore cOS, CuentaOffShore cOS2)
        {
            if (cOS.dueño.getAlias() == cOS2.dueño.getAlias() && (int)cOS == (int)cOS2)
            {
                return true;
            }

                return false;
        }

        /// <summary>
        /// Sobrecarga opuesta al ==
        /// </summary>
        /// <param name="cOS"></param>
        /// <param name="cOS2"></param>
        /// <returns></returns>
        public static bool operator != (CuentaOffShore cOS, CuentaOffShore cOS2)
        {
            return !(cOS == cOS2);
        }
        #endregion


    }
}
