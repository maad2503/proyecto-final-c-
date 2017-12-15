using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Junior Rodriguez   15-EISM-1-102
             Yonelbis Borgen    12-MISM-1-172
             Miguel Almonte     04-EISN-1-324
             Seccion            908
             */
            Console.WriteLine(" Junior Rodriguez     15-EISM-1-102\n Yonelbis Borgen     12-MISM-1-172\n Miguel Almonte      04-EISN-1-324");
            int fin = 0;
            int mejor = 0;
            while (fin == 0)//Permita que el juego no salga hasta que así lo decida el ususario
            {

                int desicionInicial;
                Console.WriteLine("           Juego de los múltiplos               ");
                Console.WriteLine("   Seleccione una opción \n(Introduzca el numero)      ");
                Console.WriteLine("1)Jugar\n2)Reglas\n3)Salir");
                //Lee las Opciones principales.
                desicionInicial = Convert.ToInt32(Console.ReadLine());

                if (desicionInicial == 1)//Opción de jugar seleccionada
                {
                    int dificultad;
                    Console.WriteLine("Elija la dificultad:\n1) Muy Fácil \n2) Fácil\n3) Normal \n4) Difícil \n5) Dios \n(Introduzca el numero) ");
                    dificultad = Convert.ToInt32(Console.ReadLine()); //Permite al usuario introducir la dificultad
                    int dif1 = 0;
                    int dif2 = 0;
                    

                    switch (dificultad)
                    {
                        case 1:
                            dif1 = 1; dif2 = 11;
                            break;
                        case 2:
                            dif1 = 1; dif2 = 21;
                            break;

                        case 3:
                            dif1 = 1; dif2 = 31;
                            break;

                        case 4:
                            dif1 = 1; dif2 = 61;
                            break;

                        case 5:
                            dif1 = 1; dif2 = 91;
                            break;
                    }


                Start: //Da inicio al juego en sí
                    int num1, num2, result;
                    int limit = 0;
                    int max = 0;
                    int bueno = 0;
                    int malo = 0;
                    int desicion = 0;

                    Otro:
                    Random numberGenerator = new Random();
                    num1 = numberGenerator.Next(minValue: dif1,maxValue: dif2);
                    num2 = numberGenerator.Next(minValue: dif1,maxValue: dif2);
                Trata://Se repite el proceso para que se trate nuevamente de dar con la respuesta.
                    


                    while (limit < 3) //Controla que el usuario solo tenga 3 intentos.
                    {
                        Console.Write(num1 + "X" + num2 + "=");
                        result = Convert.ToInt32(Console.ReadLine());//Lee la respuesta que da el usuario

                        if (num1 * num2 == result) //Verifica si la respuesta fue correcta
                        {
                            Console.WriteLine("Buen Trabajo!");
                            max++;
                            bueno++;
                            goto Otro;
                        }
                        else
                        { //Si la respuesta fue falsa
                            if (limit == 2) {
                                //Se establece que ya perdió
                                Console.WriteLine("Van 3 manín, ta ponchao'");
                            }
                            else
                            {//Se establece que aún quedan intentos.
                                Console.WriteLine("Te la bebite! Trata otra vez");
                            }
                            limit++;
                            malo++;
                            max++;
                            goto Trata;
                        }
                    }
                    

                    if(bueno > mejor)
                    {//Verifica si la nueva puntuacion ha sido la mas alta y la coloca de ser así
                        mejor = bueno;
                    }
                    //Muestra los resultados
                    Console.WriteLine("Resultados:");
                    Console.WriteLine("Correctos: " + bueno + " \nIncorrectos: " + malo+" \nMejor puntuacion: "+mejor);

                    Console.ReadKey();
                invalido: //Verifica si se seguirá jugando o no
                    Console.WriteLine("Desea seguir participando?(Introduzca el numero)\n1)Si\n2)No");

                    desicion = Convert.ToInt32(Console.ReadLine());

                    if (desicion == 1)
                    {
                        goto Start;
                    }
                    else if (desicion == 2)
                    {
                        fin = 1;
                    }
                    else
                    {
                        Console.WriteLine("Seleccion invalida...");
                        goto invalido;
                    }
                }
                else if (desicionInicial == 2)//Muestra las reglas
                {
                    //reglas
                    /*El propósito del juego es responder correctamente tantas multiplicaciones como sea posible.
                     Cuando fallas una, deberás tratar nuevamente hasta hacerla bien, pero ten en cuenta que solo
                     puedes fallar 3 veces en el juego antes de perder.
                     Disfruta!!*/

                    Console.WriteLine("El propósito del juego es responder correctamente tantas multiplicaciones como sea posible.\n" +
                         "Cuando fallas una, deberás tratar nuevamente hasta hacerla bien, pero ten en cuenta que solo\n" +
                         "puedes fallar 3 veces en el juego antes de perder.\n" +
                         "Disfruta!!");
                     
                }
                else if (desicionInicial == 3)//Sale del juego.
                {
                    fin = 1;
                }
                else
                {
                    Console.WriteLine("Introduzca una opcion correcta\n");
                }
            }
            Console.Write("Byeeeeee");
            Console.ReadKey();
        }
    }
}
