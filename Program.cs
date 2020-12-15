using System;
using teste.Classes;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            // professor BartSimpson = new professor();

            // Console.WriteLine("digite quantas horas foram trabalhadas: ");

            // BartSimpson.hora = float.Parse(Console.ReadLine());

            // Console.WriteLine("Digite o valor da aula dada: ");

            // BartSimpson.valorAula = float.Parse(Console.ReadLine());
            
            // Console.WriteLine($"O valor a receber é {BartSimpson.matematica()}");


            professor RegisLeandro = new professor();

            RegisLeandro.Professor = "Regis";

            Console.WriteLine("digite quantas horas foram trabalhadas: ");

            RegisLeandro.hora = float.Parse(Console.ReadLine());
            
            Console.WriteLine($"O professor {RegisLeandro.Professor} tem a receber R${RegisLeandro.matematica(RegisLeandro.hora)}");
        }
    }
}
