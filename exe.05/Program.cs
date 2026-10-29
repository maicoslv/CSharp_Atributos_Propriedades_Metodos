using System;

namespace AlunoMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste 1: Aluno Aprovado (Nota 8.0 e 7.0 => Média 7.5)
            Aluno aluno1 = new Aluno("Carlos", 8.0, 7.0);

            Console.WriteLine($"Aluno: {aluno1.Nome}");
            Console.WriteLine($"Média: {aluno1.CalcularMedia():F1}");
            Console.WriteLine($"Situação: {aluno1.ObterSituacao()}");

            Console.WriteLine("-----------------------------");

            // Teste 2: Aluno Reprovado (Nota 5.0 e 6.0 => Média 5.5)
            Aluno aluno2 = new Aluno("Ana", 5.0, 6.0);

            Console.WriteLine($"Aluno: {aluno2.Nome}");
            Console.WriteLine($"Média: {aluno2.CalcularMedia():F1}");
            Console.WriteLine($"Situação: {aluno2.ObterSituacao()}");
        }
    }
}