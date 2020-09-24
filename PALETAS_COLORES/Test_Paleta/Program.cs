using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Paleta;

namespace Test_Paleta
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera temp1 = new Tempera(ConsoleColor.Cyan, "HERIK", 0);
            Tempera temp2 = new Tempera(ConsoleColor.Red, "HE", 0);
            Tempera temp3 = new Tempera(ConsoleColor.Red, "HEt", 0);
            Tempera temp4 = new Tempera(ConsoleColor.Yellow, "HweE", 0);
            Tempera temp5 = new Tempera(ConsoleColor.Red, "HweE", 0);

            string most = Tempera.Mostrar(temp1);
            Console.WriteLine(most);
            // most = Tempera.Mostrar(temp2);

            Console.WriteLine("SUMA DE TEMPERA 1 Y 2 ");
            Tempera Temperanueva = temp1 + temp2;
            most = Tempera.Mostrar(Temperanueva);
            Console.WriteLine(most);


            most = Tempera.Mostrar(temp2);
            Console.WriteLine(most);
            most = Tempera.Mostrar(temp4);
            Console.WriteLine(most);

            Console.WriteLine("SUMA DE TEMPERA 2 Y 3 ");
            Temperanueva = temp2 + temp3;
            most = Tempera.Mostrar(Temperanueva);
            Console.WriteLine(most);


            most = Tempera.Mostrar(Temperanueva);
            Console.WriteLine(most);
            most = Tempera.Mostrar(temp5);
            Console.WriteLine(most);

            Console.WriteLine("SUMA DE TEMPERA TEMPERANUEVA Y TEMPERA 5 ");
            Temperanueva = Temperanueva + temp5;
            most = Tempera.Mostrar(Temperanueva);
            Console.WriteLine(most);

            Console.WriteLine();


            Console.ReadLine();


        }
    }
}
