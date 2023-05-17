namespace Struct;
 public struct equipeS
{
public string nome;
public int campeonatos;

public decimal premiacoes;

public decimal vpremio;

public bool anoestreia;

 public equipeS(string nome){
        this.nome = nome;
    }

      public string imprimir(){
        return "\nNome:  " + this.nome;
    }


}