using System;
using Struct;

namespace EquipeEsport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct
            equipeS equipe1 = new();

            equipe1.nome = "Equipe SP2";
            equipe1.campeonatos = 10; //numero de campeonatos vencidos
            equipe1.premiacoes = 1000; //valor das premiações
            equipe1.vpremio = 100;
            equipe1.anoestreia = true; //ano de estreia, pois esta true


            Console.WriteLine("\n_______________________________________________________________");
            Console.WriteLine(equipe1.imprimir());
            Console.WriteLine("\nCampeonatos competidos anteriormente ganhos: " + equipe1.campeonatos);
            Console.WriteLine("\nValor anterior do premio: " + equipe1.premiacoes + " reais");

            CampVencido(equipe1, 200); //após a atualização, declarando valor do novo premio

            static void CampVencido(equipeS equipe1, decimal premiacoes)
            {
                equipe1.campeonatos++; //incrementando + uma vitoria

                Console.WriteLine("\nCampeonatos atualmente ganhos: " + equipe1.campeonatos);
                AttDoPremio(equipe1, 200); //adcionando valor atualizado para a premiação

                static void AttDoPremio(equipeS equipe1, decimal vpremio)
                {
                    equipe1.premiacoes = vpremio + equipe1.premiacoes;

                    Console.WriteLine("\nAtualização do premio em:  " + equipe1.premiacoes + " reais");
           

                }
            }


             VerificaAtividade(equipe1); // passa os "parametros" para dpois exibir se possui vinculo com o clube

            static void VerificaAtividade(equipeS equipe1)
            {
                if (equipe1.anoestreia == true)
                {
                    Console.WriteLine("\n* Observação: " + equipe1.nome + " novata.");
                    Console.WriteLine("\n_______________________________________________________________");
                }
                else
                {
                    Console.WriteLine("\n* Observação: " + equipe1.nome + " veterana.");
                    Console.WriteLine("\n_______________________________________________________________");
                }

            }


        }
    }
}