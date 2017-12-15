using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_2
{
    class Program
    {
        public static void MostrarTitulos()
        {

            Console.ForegroundColor = ConsoleColor.Blue;


            Console.Write("ELEGIR OPCION CON UN NUMERO Y DESPLEGAR EN PANTALLA LA ACTIVIDAD MAS IMPORTANTE QUE DEBES HACER ESTE DIA ");
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {


            // Yonelvis Abimael Borgen   12-MISN-1-172 //
            //Miguel Angel almonte      04-EISN-1-324 //
            //Junior Rodríguez          15-EISM-1-102 //
            // Seccion 0908

            MostrarTitulos();
            Console.Write("Yonelvis Abimael Borgen   12-MISN-1-172");
            Console.WriteLine();
            Console.Write("Miguel Angel almonte      04-EISN-1-324");
            Console.WriteLine();
            Console.Write("Junior Rodríguez          15-EISM-1-102");
            Console.WriteLine();

            string opcion, seguir;

            do
            {

                Console.WriteLine("\nDias de la semana...\n\n1.Lunes\n2.Martes\n3.Miercoles\n4.Jueves\n5.Viernes\n6.Sabado\n7.Domingo\n\n");
                Console.Write("Ingrese opción:");
                opcion = Console.ReadLine();

                if (opcion == "1")
                    Console.Write("El |Lunes debes ir al gimnacio y visitar a tu abuela\n");
                if (opcion == "2")
                    Console.Write("El |Martes debes ir a la iglecia\n");
                if (opcion == "3")
                    Console.Write("El |Miercoles debes jugar pelota y buscar a tu esposa\n");
                if (opcion == "4")
                    Console.Write("El |Jueves debes ir al cine y orar alas  3pm \n");
                if (opcion == "5")
                    Console.Write("El |Viernes debes ir a la reunion de pareja\n");
                if (opcion == "6")
                    Console.Write("El |Sabado tienes que ir a la peluqueria\n");
                if (opcion == "7")
                    Console.Write("El |Domingo quedate trankilo descansandoen tu casa\n");

                Console.Write("\nDesea continuar s/n ?");
                seguir = Console.ReadLine();
                Console.Clear();

                while (seguir != "s" && seguir != "n")
                {
                    Console.Write("\nDesea continuar s/n ?");
                    seguir = Console.ReadLine();
                }
            } while (seguir == "s");
        }
    }
}

