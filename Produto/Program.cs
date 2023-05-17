using Struct;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct
            ProdutoS produto1 = new();

            produto1.nome = "Refrigerante";
            produto1.marca = "Coca-Cola";
            produto1.preco = 20;
            produto1.estoque = 40;
            produto1.descontoPorcentagem = 0;
            produto1.descontoValor = 0;

            Console.WriteLine("\n_______________________________________________________________");
            Console.WriteLine(produto1.imprimir());

            desconto(produto1, 20); //declarando o desconto em porcentagem

            static void desconto(ProdutoS produto1, decimal descontoPorcentagem)
            {
                produto1.preco = produto1.preco * descontoPorcentagem / 100;
                Console.WriteLine("\nDesconto por % é de: " + produto1.preco + " reais");
            }

            descontoValor(produto1, 5); //declarando o desconto em valor

            static void descontoValor(ProdutoS produto1, decimal descontoValor)
            {
                produto1.preco = produto1.preco - descontoValor;
                Console.WriteLine("\nPreço após o desconto por valor é de: " + produto1.preco + " reais");

            }
            
            verifica(produto1, produto1.estoque);

            static void verifica(ProdutoS produto1, int estoque)
            {
                
                 Console.WriteLine("\nPossuem: " + produto1.estoque + " produtos no estoque");
            }
        }
    }
}