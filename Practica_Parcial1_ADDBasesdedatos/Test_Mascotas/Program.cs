using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcticaParcial;

namespace Test_Mascotas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Genero la conexion con la base de datos. 

            AccesoBaseDatos ado = new AccesoBaseDatos();

            //Valido la conexion.
            if (ado.ProbarConexion())
            {
                Console.WriteLine("se conectó");
            }
            else
            {
                Console.WriteLine("no se conectó");
            }

            Console.ReadLine();

            Perro perroUno = new Perro("Moro", "Pitbull",2,true);
            Perro perroDos = new Perro("Julio", "Cruza", 13, false);
            Perro perroTres = new Perro("Ramón", "Salchicha", 2, true);
            Perro perroCuatro = new Perro("José", "Angora", 4, false);
            Perro perroCinco = new Perro("Ramón", "Salchicha", 20, false);

            List<Perro> auxLista = new List<Perro>();
            auxLista.Add(perroUno);
            auxLista.Add(perroDos);
            auxLista.Add(perroTres);
            auxLista.Add(perroCuatro);
            auxLista.Add(perroCinco);

            Console.WriteLine("Desea guardar en la base de datos?");
            string rta = Console.ReadLine();
            if(rta == "s")
            {
                foreach (Perro item in auxLista)
                {
                    bool agrego = ado.AgregarDato(item);

                    if (agrego)
                    {
                        Console.WriteLine("se agregó");
                    }
                    else
                    {
                        Console.WriteLine("no se agregó");
                    }
                }
            }else
            {
                 Console.WriteLine("puto que eres.");
            }

            Console.ReadLine();

    //                                              MAIN ORIGINAL
    /*Perro perroUno = new Perro("Moro", "Pitbull");
    Perro perroDos = new Perro("Julio", "Cruza", 13, false);
    Perro perroTres = new Perro("Ramón", "Salchicha", 2, true);
    Perro perroCuatro = new Perro("José", "Angora", 2, false);
    Perro perroCinco = new Perro("Ramón", "Salchicha", 2, false);

    Gato gatoUno = new Gato("José", "Angora");
    Gato gatoDos = new Gato("Mauri", "Cruza");
    Gato gatoTres = new Gato("Fer", "Siamés");
    Gato gatoCuatro = new Gato("Fer", "Siamés");

    Console.WriteLine();

    Grupo grupoUno = new Grupo("Río", EtipoManada.Mixta);

    grupoUno += perroUno;
    grupoUno += perroDos;
    grupoUno += perroTres;
    grupoUno += perroCuatro;

    //repetidos 

    grupoUno += perroCinco; 
    grupoUno += perroUno;    
    grupoUno += gatoUno;   
    grupoUno += gatoDos;    
    grupoUno += gatoTres;

    //repetido 

    grupoUno += gatoCuatro;
    Console.WriteLine();

    //Cantidad 7 (4 perros - 3 gatos) 

    Console.WriteLine(grupoUno); 

    grupoUno -= perroUno;      
    grupoUno -= perroTres;     
    grupoUno -= gatoTres;

    //no están         

    grupoUno -= perroCinco;  
    grupoUno -= gatoTres; 
    grupoUno -= gatoCuatro; 

    Console.WriteLine();

    //Cantidad 4 (2 perros - 2 gatos) 

    Console.WriteLine(grupoUno);

    //son distintos

    if (perroUno.Equals("perroUno"))       
    Console.WriteLine("Son la misma mascota");
    else      
    Console.WriteLine("No son la misma mascota");

    //son iguales
    if (perroTres.Equals(perroCinco)) 
        Console.WriteLine("Son la misma mascota");
    else         
        Console.WriteLine("No son la misma mascota"); 
    Console.ReadLine();*/
}
    }
}
