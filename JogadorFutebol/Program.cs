using System;
using Struct;

namespace JogadorFutebol
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct
            jogadorS jogador1 = new();

            jogador1.nome = "João Pedro";
            jogador1.idade = "18 anos";
            jogador1.clube = "SP2";
            jogador1.vinculo = true; //vinculo true/ativo com o clube
            jogador1.CartoesAmarelos = 2; // cartões antes
            jogador1.CartoesVermelhos = 1;

            Console.WriteLine("\n_______________________________________________________________");
            Console.WriteLine(jogador1.imprimir());
            Console.WriteLine("\nCartões Amarelos - durante: " + jogador1.CartoesAmarelos);
            Console.WriteLine("Cartões Vermelhos - durante: " + jogador1.CartoesVermelhos);

            ContagemDeCartoesAmarelos(jogador1, 2); //após a atualização
            ContagemDeCartoesVermelhos(jogador1, 1);


            static void ContagemDeCartoesAmarelos(jogadorS jogador1, int quant)
            {
                quant = jogador1.CartoesAmarelos + quant;
                Console.WriteLine("\nCartões Amarelos - após a final: " + quant);

            }

            static void ContagemDeCartoesVermelhos(jogadorS jogador1, int quant2)
            {
                quant2 = jogador1.CartoesVermelhos + quant2;
                Console.WriteLine("Cartões Vermelhos - após a final: " + quant2);

            }

            VerificaVinculo(jogador1); // passa os "parametros" para dpois exibir se possui vinculo com o clube

            static void VerificaVinculo(jogadorS jogador1)
            {
                if (jogador1.vinculo == true)
                {
                    Console.WriteLine("\n* Observação: " + jogador1.nome + " possui vínculo com o clube.");
                    Console.WriteLine("\n_______________________________________________________________");
                }
                else
                {
                    Console.WriteLine("\n* Observação: " + jogador1.nome + " não possui vínculo com o clube.");
                    Console.WriteLine("\n_______________________________________________________________");
                }

            }




        }
    }
}