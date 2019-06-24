using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizLecturayEscritura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de la matriz

            int[,] numero;

            numero = new int[3, 3];

            for (int fila=0; fila <3; fila++)
            {
                for(int columna =0; columna<3; columna++)
                {
                    Console.WriteLine("Dame un número: ");
                    numero[fila, columna] = Convert.ToInt32(Console.ReadLine());

                }
                
            }

            Console.Clear();


            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.Write(" " + numero[fila,columna]);
                  
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
