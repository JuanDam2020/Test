using System;
using System.Diagnostics;
using System.Linq.Expressions;

/*
El programa dibuja una X utilizando asteriscos y espacios.
Hay que pedirun número entero impar mayor que 2 que es el tamaño de la X. Suponiendo que leemos cinco:
El programa controlará que sea impar y mayor que 2, en caso contrario lo debe volver a pedir.
El programa,  también debe tener control de errores (try-catch). Al leer el número, en el caso de que no sea un número entero, debe avisarnos y volver a pedirlo.
*/
namespace PracticasClase
{
    class Program
    {

        static void Main(string[] args)
        {


            PrintMenu();

        }


        public static void PrintMenu()
        {
            int option=0;
           

                do
                {

                 Console.WriteLine("1 para ejecutar el programa ");
                 Console.WriteLine("2 para salir ");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                 switch (option)
                 {
                    case 1:
                        ExecuteGameX();
                        break;
                    case 2:
                        Console.Write("Adios Gracias");
                        break;
                    default:
                        Console.WriteLine("No has ni 1 ni 2");
                        break;
                 }
                 }    catch (FormatException e)
                {
                    Console.WriteLine("No es un número válido: {0}", e.Message);
                }
            } while (option != 2);

           
        }
        public static void ExecuteGameX()
        {
            int n1 = 0;
            int y = 0;

            try
            {
                do
                {
                    Console.WriteLine("Introduce un numero mayor a 3 para crear una x");
                    Console.WriteLine("Ademas debe de ser impar");
                    n1 = Convert.ToInt32(Console.ReadLine());
                } while (n1 < 3 || (n1 % 2 == 0));

            }

            catch (FormatException e)
            {
                Console.WriteLine("No es un número válido: {0}", e.Message);
            }
            y = (n1 - 1);
            for (int i = 0; i < n1; i++)
            {
                for (int z = 0; z < n1; z++)
                {
                    if ((i == z) || ((i + z) == y))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }

        }
    }
}




