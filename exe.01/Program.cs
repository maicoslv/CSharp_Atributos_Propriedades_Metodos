using System;

namespace ExercicioProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando o objeto e passando os valores pelo construtor
            Produto p = new Produto("Notebook Gamer", 4500.00m);

            Console.WriteLine("--- Dados do Produto ---");
            Console.WriteLine($"Nome: {p.Nome}");
            Console.WriteLine($"Preço: R$ {p.Preco:F2}");
        }
    }
}