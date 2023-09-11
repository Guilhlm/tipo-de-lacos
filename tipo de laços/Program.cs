using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipo_de_laços
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do { codigo } while ( condiçao )

            int menu;

            Console.WriteLine("1- do while \n 2- for \n3- switch \n4- array \n escolha uma das opçoes");
            menu = int.Parse(Console.ReadLine());
            
            if (menu == 1)
            {
                int contador = 4;

                do
                {
                    Console.WriteLine("Do While" + contador);
                    contador++;

                }while (contador <= 3);



            }





            Console.ReadKey();
        }
    }
}
