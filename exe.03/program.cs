using System;

namespace ExercicioProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um produto com preço de R$ 200,00[cite: 4]
            Produto p = new Produto("Camisa Polo", 200.00m);

            Console.WriteLine("--- Antes do Desconto ---");
            Console.WriteLine($"Produto: {p.Nome}");
            Console.WriteLine($"Preço Original: R$ {p.Preco:F2}");

            // Aplica o desconto de 10%[cite: 4]
            p.AplicarDesconto(10.00m);

            Console.WriteLine("\n--- Depois do Desconto ---");
            Console.WriteLine($"Preço com Desconto: R$ {p.Preco:F2}");
        }
    }
}