using System;

namespace ExercicioPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Criando uma instância do Pedido
            Pedido meuPedido = new Pedido(5001, "Maicon", 250.00m, 20.00m);

            // 2. Chamando o método ObterResumo() e imprimindo a partir do Program.cs
            Console.WriteLine("=== RESUMO DO PEDIDO ===");
            string resumo = meuPedido.ObterResumo();
            Console.WriteLine(resumo);
            Console.WriteLine();

            // 3. Calculando totais e decidindo a exibição no Program.cs
            decimal totalSemDesconto = meuPedido.CalcularTotal();
            decimal totalComDesconto10 = meuPedido.CalcularTotalComDesconto(10.0m);

            Console.WriteLine("=== DETALHES DE VALORES ===");
            Console.WriteLine($"Valor dos Produtos : R$ {meuPedido.ValorProdutos:F2}");
            Console.WriteLine($"Valor do Frete    : R$ {meuPedido.ValorFrete:F2}");
            Console.WriteLine($"Total Sem Desconto: R$ {totalSemDesconto:F2}");
            Console.WriteLine($"Total Com Desconto (10% nos produtos): R$ {totalComDesconto10:F2}");
        }
    }
}