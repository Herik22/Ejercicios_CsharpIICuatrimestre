using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //           *********************  INICIO TEST PRIMERA PARTE ************************************************************
            Auto a1 = new Auto("Rojo", "Ferrari");
            Auto a2 = new Auto("Amarillo", "Porche");
            Auto a3 = new Auto("Negro", "BMW"); 
            Auto a4 = new Auto("Verde", "Ford");

            DepositoDeAutos da = new DepositoDeAutos(3); 
            if ((da + a1))
            {
                Console.WriteLine("Se ha agregado el item!!!");
            }

            da.Agregar(a2);
            da.Agregar(a3);

            if (!da.Agregar(a4)) 
            {
                Console.WriteLine("No se pudo agregar el item!!!");
            }

            Console.WriteLine(da);

            da.Remover(a2);

            if (! (da - a4)) 
            {
                Console.WriteLine("No se pudo remover el item!!!"); 
            }

            Console.WriteLine(da);
            Console.ReadLine();
            */ //           *********************  FIN TEST PRIMERA PARTE ************************************************************

            /* //           *********************  INICIO TEST SEGUNDA PARTE ************************************************************
            Cocina c1 = new Cocina(111, 12300, false);
            Cocina c2 = new Cocina(112, 15000, true);
            Cocina c3 = new Cocina(113, 5600, false);
            DepositoDeCocinas dc = new DepositoDeCocinas(5);
            dc.Agregar(c1);
            dc.Agregar(c2);
            if (!(dc + c3))
            {
                Console.WriteLine("No se pudo agregar el item!!!");
            }
            Console.WriteLine(dc);
            dc.Remover(c2);
            if (!(dc - c2))
            {
                Console.WriteLine("No se pudo remover el item!!!");
            }
            Console.WriteLine(dc);
            Console.ReadLine(); */ //           *********************  FIN TEST PRIMERA PARTE ************************************************************

            Console.WriteLine("QUE ONDA PUTO ");
            Console.ReadLine();
        }
    }
}
