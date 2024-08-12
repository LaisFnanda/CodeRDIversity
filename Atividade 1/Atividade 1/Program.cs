using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Atividade 1

namespace IOTGeladeira
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Geladeira;
            Geladeira = new string[3,2];

            Console.WriteLine("ITENS DA GELADEIRA \n");

            Geladeira[2, 0] = "OVOS,CARNES      ";
            Geladeira[1, 0] = "ENLATADOS        ";
            Geladeira[0, 0] = "HORTIFRUTI       ";

            Geladeira[2, 1] = "CHARCUTARIA";
            Geladeira[1, 1] = "LATICINIOS";
            Geladeira[0, 1] = "HORTIFRUTI";

            for (int i = 0; i < Geladeira.GetLength(0); i++)
            {
                for (int j = 0; j < Geladeira.GetLength(1); j++)
                {
                    Console.Write("A" + i + " " + " C" + j + " ");
                    Console.Write($"{Geladeira[i, j]}");
                }
                Console.WriteLine();
                
            }

            Console.ReadKey();


        }
              
            
       





    }

}