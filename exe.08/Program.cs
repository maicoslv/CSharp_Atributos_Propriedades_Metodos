using System;

namespace ExercicioCarrinho
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando um item do carrinho (ex: 3 Teclados de R$ 150,00 cada)
            CarrinhoItem item = new CarrinhoItem("Teclado Mecânico", 150.00m, 3);

            Console.WriteLine("=== CARRINHO DE COMPRAS ===");
            Console.WriteLine($"Item: {item.Descricao}");
            Console.WriteLine($"Preço Unitário: R$ {item.PrecoUnitario:F2}");
            Console.WriteLine($"Quantidade: {item.Quantidade}\n");

            // Calculando subtotal simples
            decimal subtotal = item.CalcularSubtotal();
            Console.WriteLine($"Subtotal (sem desconto): R$ {subtotal:F2}");

            // Calculando subtotal com 10% de desconto
            decimal percentual = 10.0m;
            decimal subtotalComDesconto = item.CalcularSubtotalComDesconto(percentual);
            Console.WriteLine($"Subtotal (com {percentual}% de desconto): R$ {subtotalComDesconto:F2}");
        }
    }
}