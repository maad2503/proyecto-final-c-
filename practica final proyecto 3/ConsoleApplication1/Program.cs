using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programas_1
{
    class Program
    {
        public static void MostrarTitulos()
        {

            Console.ForegroundColor = ConsoleColor.Blue;


            Console.Write("Se ingresa la cantidad de agua caida, en mílimetros día a día durante un mes.Se pide determinar el día de mayor lluvia, el de menor y el promedio ");
            Console.WriteLine();


        }

        static void Main(string[] args)
        {
            // Yonelvis Abimael Borgen   12-MISN-1-172 //
            //Miguel Angel almonte       04-EISN-1-324 //
            //Junior Rodríguez           15-EISM-1-102 //
            // seccion 0908
           
            MostrarTitulos();

            int flag = 0, i = 0, mayordia = 0, menordia = 0, x = 6;
            int[] dia = new int[31];
            float menor = 0, mayor = 0, promedio = 0, contagua = 0;
            float[] agua = new float[x + 1];
            Console.WriteLine();
            Console.Write("Yonelvis Abimael Borgen   12-MISN-1-172");
            Console.WriteLine();
            Console.Write("Miguel Angel almonte      04-EISN-1-324");
            Console.WriteLine();
            Console.Write("Junior Rodríguez          15-EISM-1-102");
            Console.WriteLine();

            do
            {
                Console.WriteLine();
                Console.Write("Ingrese dia:");
                dia[i] = int.Parse(Console.ReadLine());

                Console.Write("Ingrese agua caida:");
                agua[i] = float.Parse(Console.ReadLine());

                if (flag == 0)
                {
                    mayordia = dia[i];
                    menordia = dia[i];
                    mayor = agua[i];
                    menor = agua[i];
                    flag = 1;
                }
                else
                {
                    if (agua[i] > mayor)
                    {
                        mayordia = dia[i];
                        mayor = agua[i];
                    }
                    if (agua[i] < menor)
                    {
                        menordia = dia[i];
                        menor = agua[i];
                    }
                }

                contagua += agua[i];

                if (i == 5)
                {
                    Console.Write("quieres calcular tambien el domingo s/n ?");
                    if (Console.ReadLine() == "s")
                        x = x + 1;
                }
                i++;
            } while (i < x);

            promedio = contagua / i;

            if (menor == mayor)
            {
                Console.Write("\nNo hubo mayor y menor dia de agua caida, fue igual para todos los dias {0}", menor);
            }
            else
            {
                Console.WriteLine("\nLa mayor cantidad de agua caida fue de {0} milímetros el/los dia/s ...", mayor);
                for (i = 0; i < x; i++)
                    if (agua[i] == mayor)
                        Console.Write("\nDia {0}", dia[i]);

                Console.WriteLine("\n\nLa menor cantidad de agua caida fue de {0} milímetros el/los dia/s ...", menor);
                for (i = 0; i < x; i++)
                    if (agua[i] == menor)
                        Console.Write("\nDia {0}", dia[i]);
            }
            Console.WriteLine("\n\nEl promedio de agua caida en {0} dias es {1}", x, promedio);
            Console.Read();
        }
    }
}




