using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculo_lavadero;

namespace TestLAVADERO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo v1 = new Vehiculo("A027lpe", 4, eMarcas.Ford);

            Camion c1 = new Camion("ao27lpe", 4, eMarcas.Iveco, 4300);
            Camion c2 = new Camion("ao33pe", 8, eMarcas.Honda, 56000);
            Camion camionNOEXISTE = new Camion("ao3", 12, eMarcas.Ford, 5000);

            Auto a1 = new Auto("mllb-140", 4, eMarcas.Ford, 6);
            Auto aNOEXISTE = new Auto("ml40", 6, eMarcas.Ford, 8);

            Moto m1 = new Moto("ah420", 2, eMarcas.Zanella, 250);
            Moto m2 = new Moto("amk123", 2, eMarcas.Scania, 650);

            Console.WriteLine(c1.mostrarCamion());
            Console.WriteLine(a1.mostrarAuto());
            Console.WriteLine(m1.mostrarMoto());

            Lavadero l1 = new Lavadero(300, 600, 200); // auto 300 Camion 600 Moto 200 

            l1 += a1;
            l1 += m2;
            l1 += c1;
            l1 += c2;
            l1 += m1; // 5 mensajes de autos eliminados 

            l1 += a1; // deberia decir que no se agrego porque ya existe



            Console.WriteLine("{0}", l1.lavadero);

            Console.WriteLine("TOTAL FACTURADO: {0}", l1.MostrarTotalFacturado()); // esperado 1900

            Console.ReadLine();

            Console.WriteLine("TOTAL MOTO: {0}", l1.MostrarTotalFacturado(eVehiculos.Moto)); // ESPERADO 400
            Console.ReadLine();
            Console.WriteLine("TOTAL AUTO: {0}", l1.MostrarTotalFacturado(eVehiculos.Auto)); // ESPERADO 300
            Console.ReadLine();
            Console.WriteLine("TOTAL CAMION: {0}", l1.MostrarTotalFacturado(eVehiculos.Camion)); // ESPERADO 1200

            // ACA COMIENZO A ELIMINAR 
            Console.ReadLine();

            l1 -= m1;
            l1 -= m2;    // dos mensajes de que se elimino 

            l1 -= camionNOEXISTE;
            l1 -= aNOEXISTE;  // dos mensajes de que no se elimino porque no existe

            Console.WriteLine("{0}", l1.lavadero);

            Console.WriteLine("TOTAL FACTURADO: {0}", l1.MostrarTotalFacturado()); // esperado 1100

            Console.ReadLine();

            Console.WriteLine("TOTAL MOTO: {0}", l1.MostrarTotalFacturado(eVehiculos.Moto)); // ESPERADO 200
            Console.ReadLine();
            Console.WriteLine("TOTAL AUTO: {0}", l1.MostrarTotalFacturado(eVehiculos.Auto)); // ESPERADO 300
            Console.ReadLine();
            Console.WriteLine("TOTAL CAMION: {0}", l1.MostrarTotalFacturado(eVehiculos.Camion)); // ESPERADO 600

            Console.ReadLine();
        }
    }
}
