namespace Struct;
public struct ProdutoS
{
    public string nome;
    public string marca;

    public decimal preco;

    public int estoque;

    public decimal descontoPorcentagem;

    public decimal descontoValor;


    public ProdutoS(string nome, string marca){
        this.nome = nome;
        this.marca = marca;
    }

      public string imprimir(){
        return "\nNome:  " + this.nome +
        "\nMarca:  " + this.marca;
    }


}