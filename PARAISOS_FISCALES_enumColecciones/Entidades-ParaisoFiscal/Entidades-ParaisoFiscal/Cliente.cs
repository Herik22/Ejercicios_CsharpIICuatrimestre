using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_ParaisoFiscal
{
    public class Cliente
    {     
        #region ATRIBUTOS 

        private string aliasParaIncognito;
        private  string nombre;
        private eTipoDeCliente tipoDeCliente;
        Random numRand = new Random();
        #endregion

        #region METODOS

        /// <summary>
        /// Genera un Alias de cliente conformador por : numero aleatorio entre  (1000-9999) y lo concatena a el tipo de cliente. 
        /// </summary>
        private void crearAlias() // REVISAR DEVUELVE SIEMPRE EL MISMO NUMERO RANDOM
        {
    
            this.aliasParaIncognito = numRand.Next(1000, 9999).ToString()+ this.tipoDeCliente.ToString();
        }

        /// <summary>
        /// Retorna el alias del Cliente. si no tiene se genera un automatico.
        /// </summary>
        public string getAlias()
        {
            if(this.aliasParaIncognito == "Sin Alias")
            {
                this.crearAlias(); // genero su alias incognito
                return this.aliasParaIncognito;

            }
            return this.aliasParaIncognito;

        }

        /// <summary>
        /// accede a la informacion del cliente. uso de StringBuilder.
        /// </summary>
        private string  RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Alias : {0}", this.getAlias());
            sb.AppendLine();
            sb.AppendFormat("Nombre : {0}", this.nombre);
            sb.AppendLine();
            sb.AppendFormat("Tipo de Cliente: {0}", this.tipoDeCliente.ToString());
            sb.AppendLine();
            return sb.ToString();
        }

        /// <summary>
        /// Retorna la informacion del cliente recibido como parametro.
        /// </summary>
        /// <param name="c1"></param>
        /// <returns></returns>
        public static string RetornarDatos(Cliente c1)
        {
            return c1.RetornarDatos();
        }

        #endregion
      
        #region CONSTRUCTORES 

        private Cliente ()
        {
            this.nombre = "N.N";
            this.aliasParaIncognito = "Sin Alias";
            this.tipoDeCliente = eTipoDeCliente.SinTipo;
        }

        public Cliente(eTipoDeCliente tipodecliente):this() // anido el constructor anterior
        {
            this.tipoDeCliente = tipodecliente;
        }

        public Cliente(eTipoDeCliente tipocliente, string nombre):this(tipocliente)
        {
            this.nombre = nombre;
        }
        #endregion

        #region SOBRECARGAS
        #endregion
    }
}
