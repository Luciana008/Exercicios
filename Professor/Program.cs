using System;
using Struct;

namespace Professor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct
            professorS professor1 = new();

            professor1.nome = "Lucas";
            professor1.materia = "Agroonegócio";
            professor1.salario = 3500;


            Console.WriteLine("\n_______________________________________________________________");
            Console.WriteLine(professor1.imprimir());



            reajusteValor(professor1, 100);
            static void reajusteValor(professorS professor1, decimal valor)
            {
                professor1.salario = professor1.salario + valor;

                Console.WriteLine("\nO reajuste por valor é de: " + professor1.salario);
            }




            reajustePorcentagem(professor1, 25);
            static void reajustePorcentagem(professorS professor1, decimal porcentagem)
            {
                professor1.salario = professor1.salario * (porcentagem / 100);

                Console.WriteLine("\nO reajuste por % é de: " + professor1.salario);
            }


            reajusteFaltasValor(professor1, 20, 50);
            static void reajusteFaltasValor(professorS professor1, decimal falta, decimal valor)
            {
                professor1.salario = professor1.salario - valor;

                Console.WriteLine("\nO reajuste por valor em faltas é de: " + professor1.salario);
            }


            reajusteFaltasPorcentagem(professor1, 45);
            static void reajusteFaltasPorcentagem(professorS professor1, decimal porcentagem)
            {
                professor1.salario = professor1.salario * (porcentagem / 100);

                Console.WriteLine("\nO reajuste por falta em % é de: " + professor1.salario);
            }

            AumentarHorario(professor1, 100);
            static void AumentarHorario(professorS professor1, int horas)
            {
                professor1.horarios = professor1.horarios + horas;

                professor1.salario = professor1.salario + (professor1.salario * horas) / 1000;

                Console.WriteLine("\nAumento da carga horária: " + professor1.horarios);
                Console.WriteLine("\nReajuste salarial: " + professor1.horarios);

            }













        }
    }
}