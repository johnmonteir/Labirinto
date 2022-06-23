using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto
{
    class projetolabirinto
    {
        //Titulo do Jogo. 
        static string titulo = "Jogo Labirinto:";



        static string[,] labirinto = new string[21, 30]
        {                                                                                       //30 colunas
            {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},
            {"#","#"," ","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},
            {"#","#"," ","#","#","#","#","#"," "," "," "," ","#","#","#","#","#"," ","#","#","#","#","#"," "," "," "," "," "," ","F"},
            {"#"," "," "," "," "," ","#","#"," ","#","#"," ","#","#","#","#","#"," ","#","#"," ","#","#"," ","#","#","#","#","#","#"},
            {"#"," ","#","#","#"," ","#","#"," ","#","#"," ","#"," ","#","#","#"," ","#","#"," ","#","#"," ","#","#","#","#","#","#"},
            {"#"," ","#","#","#"," ","#","#"," ","#","#"," ","#"," ","#","#","#"," ","#","#"," ","#","#"," ","#","#","#","#","#","#"},
            {"#"," ","#","#","#"," "," "," "," ","#","#"," ","#"," ","#"," "," "," "," "," "," ","#","#"," ","#","#","#","#","#","#"},
            {"#"," "," "," ","#","#","#","#","#","#","#"," ","#"," ","#"," ","#","#"," ","#"," ","#","#"," "," "," "," "," "," ","#"},
            {"#","#","#"," ","#","#","#","#","#","#","#"," "," "," ","#"," ","#","#"," ","#"," ","#","#","#","#","#","#","#"," ","#"},
            {"#","#","#"," "," "," "," "," "," ","#","#","#"," "," ","#"," "," ","#"," ","#"," ","#","#","#","#","#","#","#"," ","#"},
            {"#","#","#","#","#","#","#","#"," ","#","#","#"," "," ","#","#"," ","#"," ","#"," ","#","#","#","#","#","#","#"," ","#"},
            {" ","#","#","#","#","#","#","#"," ","#","#","#"," "," ","#","#"," ","#"," ","#"," "," "," "," "," ","#","#","#"," ","#"},
            {" ","#","#","#","#","#","#","#"," ","#","#","#"," "," ","#","#"," ","#","#","#","#","#","#","#"," ","#","#","#"," ","#"},
            {" "," "," "," "," "," ","#","#"," ","#","#","#","#"," ","#","#"," ","#","#","#","#","#","#","#"," ","#","#","#"," ","#"},
            {" "," ","#","#","#"," ","#","#"," ","#","#","#","#"," ","#","#"," ","#","#","#","#","#","#","#"," "," "," "," "," ","#"},
            {" "," ","#","#","#"," ","#","#"," ","#","#","#","#"," ","#","#"," "," "," "," "," ","#","#","#"," ","#","#","#"," ","#"},
            {" ","#","#","#","#"," ","#","#"," ","#","#","#","#"," ","#","#","#","#","#","#"," ","#","#"," "," ","#","#","#"," ","#"},
            {" ","#","#"," "," "," ","#","#"," "," "," "," ","#"," ","#","#","#","#","#","#"," ","#","#"," ","#","#","#","#"," ","#"},
            {"#","#","#"," ","#","#","#","#"," ","#","#","#","#"," "," "," "," "," "," ","#"," ","#","#"," ","#","#","#","#"," ","#"},
            {"#","#","#"," "," "," "," "," "," ","#","#","#","#","#"," ","#","#","#"," "," "," ","#","#"," "," "," "," "," "," ","#"},
            {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},//24 linhas
        };
        static string player = ">";
        static int posilinha = 13;
        static int posicoluna = 0;

        static void Main(string[] args)
        {
            
            Console.Title = titulo;
            bool fimdejogo = false;
            labirinto[13, 0] = player;
            while (!fimdejogo)
            {
                Console.Clear();
                Console.WriteLine("DIGITE O COMANDO:");
                Console.WriteLine("• W = CIMA.");
                Console.WriteLine("• A = ESQUERDA.");
                Console.WriteLine("• S = BAIXO.");
                Console.WriteLine("• D = DIREITA.");

                //linhas
                for (int linha = 0; linha < 21; linha++)
                {   //Colunas
                    for (int coluna = 0; coluna < 30; coluna++)
                    {
                        Console.Write(labirinto[linha, coluna]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.Write("MEU COMANDO É:");
                string comando = Console.ReadLine().ToUpper();
                // intruçoes 
                if (comando == "W")
                {
                    if (labirinto[posilinha - 1, posicoluna] != "#")
                    {
                        labirinto[posilinha, posicoluna] = " ";
                        posilinha--;
                    }

                }
                else if (comando == "A")
                {
                    if (labirinto[posilinha, posicoluna - 1] != "#")
                    {
                        labirinto[posilinha, posicoluna] = " ";
                        posicoluna--;
                    }
                }
                else if (comando == "S")
                {
                    if (labirinto[posilinha + 1, posicoluna] != "#")
                    {
                        labirinto[posilinha, posicoluna] = " ";
                        posilinha++;
                    }
                }
                else if (comando == "D")
                {
                    if (labirinto[posilinha, posicoluna + 1] != "#")
                    {
                        labirinto[posilinha, posicoluna] = " ";
                        posicoluna++;
                    }
                }

                labirinto[posilinha, posicoluna] = player;

                if (labirinto[2, 29] == player)
                fimdejogo = true;

            }
            Console.Clear();
            Console.WriteLine("PARABÉNS!!! VOCÊ CHEGOU AO FIM DO LABIRINTO!");
            Console.WriteLine("Tecle ENTER para finalizar.");
            Console.ReadKey();
        }
    }
}

