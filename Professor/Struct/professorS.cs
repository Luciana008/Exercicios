namespace Struct;
 public struct professorS
{
    public string nome;
    public decimal salario;
    public string materia;
    public decimal horarios;


    public professorS(string nome, string materia){
        this.nome = nome;
        this.materia = materia;
    }

    public string imprimir(){
        return "\nNome:  " + this.nome +
               "\nDisciplina:  " + this.materia;
    }


}