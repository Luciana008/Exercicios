namespace Struct;
 public struct jogadorS
{
    public string nome;
    public string idade;
    public string clube;

    public bool vinculo;

    public int CartoesAmarelos;

    public int CartoesVermelhos;

    public int ContagemDeCartoesAmarelos;

    public int ContagemDeCartoesVermelhos;

   public jogadorS(string nome, string idade, string clube, bool vinculo){
        this.nome = nome;
        this.idade = idade;
        this.clube = clube;
        this.vinculo = vinculo;
    }

      public string imprimir(){
        return "\nNome:  " + this.nome +
               "\nIdade:  " + this.idade +
               "\nClube: " + this.clube;
    }





}

