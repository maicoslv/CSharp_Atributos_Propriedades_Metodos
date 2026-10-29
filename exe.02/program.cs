using System;

namespace ExercicioProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando o produto
            Produto p = new Produto("Notebook Gamer", 4500.00m);

            // Definindo a quantidade pedida no exercício (4 unidades)[cite: 3]
            int quantidadeUnidades = 4;

            // Chamando o método CalcularTotal
            decimal valorTotal = p.CalcularTotal(quantidadeUnidades);

            // Exibindo os valores no console
            Console.WriteLine("--- Dados do Produto ---");
            Console.WriteLine($"Nome: {p.Nome}");
            Console.WriteLine($"Preço Unitário: R$ {p.Preco:F2}");
            Console.WriteLine($"Quantidade: {quantidadeUnidades}");
            Console.WriteLine($"Valor Total: R$ {valorTotal:F2}");
        }
    }
}