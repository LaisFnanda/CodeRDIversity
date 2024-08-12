
using System;
namespace IOTGeladeira
{

    class Program
    {
        public static void Main()
        {

            string[][,] Geladeira = new string[3][,]
            {
                new string[,] {{ "Espinafre ", "Brocolis ", "Repolho"} , { "Laranja   ", "Banana ", "Abacaxi "}, { "Alface    ", "Limao ","Tomate"} },
                new string[,] { { "Milho     ", "Atum ", "Ervilha " },{ "Palmito   ", "Yogurte", "Leite " }, {"Quejo     ", "Requejao ", "Molho" } },
                new string[,] { { "Presunto  ", "Salsicha ", "Salame " }, { "Bacon     ", "Codorna", "Ovos " }, {"Acem      ", "Mignon" , "Fraldinha" } }
            };
            
            
              for (int i = 0; i < Geladeira.Length; i++)
            {

                int x = 0;

                for (int j = 0; j < Geladeira[i].GetLength(x); j++)
                {
                                      
                    for (int k = 0; k < Geladeira[j].Rank; k++)
                        Console.Write(" Geladeira [Andar " + i + "][Container " + j + ", Posicao " + k + "]: " + Geladeira[i][j, k] + " ");
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
        }
    }
}