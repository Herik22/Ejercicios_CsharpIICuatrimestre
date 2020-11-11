using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Parcial
{           //Crear el manejador necesario para que, una vez capturado el evento, se imprima en un archivo de texto: 
            //la fecha (con hora, minutos y segundos) y el total de la cartuchera (en un nuevo renglón). 
            //Se deben acumular los mensajes. 
            //El archivo se guardará con el nombre 'tickets.log' en la carpeta 'Mis documentos' del cliente.
            //El manejador de eventos (c_gomas_EventoPrecio) invocará al método (de clase) 
            //ImprimirTicket (se alojará en la clase Ticketeadora), que retorna un booleano 
            //indicando si se pudo escribir o no.
    public static class Ticketeadora <T> where T : Utiles
    {
        public static bool ImprimirTicket (Cartuchera <T> c1)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\tickets.log";
            bool rta = true;
            try
            {
                if (File.Exists(ruta))
                {
                    using (StreamWriter sw = new StreamWriter(ruta,true))
                    {
                        sw.WriteLine("Fecha : {0}",DateTime.Now);
                        sw.WriteLine("Total Cartuchera: {0}", c1.PrecioTotal);                        
                    }
                }else
                {
                    using (StreamWriter sw = new StreamWriter(ruta, false))
                    {
                        sw.WriteLine("Fecha : {0}", DateTime.Now);
                        sw.WriteLine("Total Cartuchera: {0}", c1.PrecioTotal);
                    }
                }
            }
            catch (Exception e )
            {

                return false;
            }          
            return rta;
        }
    }
}
