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


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\n ____   __   ____   __   ____        ____  ____        __     __    ___   __   ____ \r\n(_  _) (  ) (  _ \\ /  \\ / ___)      (    \\(  __)      (  )   / _\\  / __) /  \\ / ___)\r\n  )(    )(   ) __/(  O )\\___ \\       ) D ( ) _)       / (_/\\/    \\( (__ (  O )\\___ \\\r\n (__)  (__) (__)   \\__/ (____/      (____/(____)      \\____/\\_/\\_/ \\___) \\__/ (____/\r\n                                                                                    \r\n");
            Console.Write("1- do while \n2- for \n3- switch \n4- array \nescolha uma das opçoes: ");
            menu = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Gray;

            if (menu == 1)
            {
                int contador = 4;

                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Do While" + contador);
                    contador++;

                }while (contador <= 3);

            }
            else if (menu == 2)
            {
                for (int cont = 0 ; cont < 3; cont++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("for :" + cont);
                }
            }
            else if (menu == 3)
            {
                int condicao = 3;

               switch (condicao)
                {
                    case 0:
                        Console.WriteLine("");
                        Console.WriteLine("estou na condiçao 0");
                        break;

                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("estou na condiçao 1");
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("estou na condiçao 2");
                        break;

                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("estou na condiçao 3");
                        break;

                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("estou na condiçao 4");
                        break;

                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("estou na condiçao 5");
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("opçao invalida");
                        break;
                }
            }







            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");
            Console.WriteLine("press <ENTER> for exit");
            Console.ReadKey();
        }
    }
}
