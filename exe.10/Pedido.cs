namespace ExercicioPedido
{
    public class Pedido
    {
        // Propriedades com encapsulamento (private set)
        public int Numero { get; private set; }
        public string Cliente { get; private set; }
        public decimal ValorProdutos { get; private set; }
        public decimal ValorFrete { get; private set; }

        // Construtor para inicializar o pedido
        public Pedido(int numero, string cliente, decimal valorProdutos, decimal valorFrete)
        {
            Numero = numero;
            Cliente = cliente;
            ValorProdutos = valorProdutos;
            ValorFrete = valorFrete;
        }

        // Método que calcula o valor total simples (Produtos + Frete)
        public decimal CalcularTotal()
        {
            return ValorProdutos + ValorFrete;
        }

        // Método que calcula o total aplicando desconto sobre o valor dos produtos
        public decimal CalcularTotalComDesconto(decimal percentualDesconto)
        {
            decimal valorDesconto = ValorProdutos * (percentualDesconto / 100m);
            decimal produtosComDesconto = ValorProdutos - valorDesconto;
            return produtosComDesconto + ValorFrete;
        }

        // Método que gera uma representação textual do pedido sem fazer impressões no console[cite: 19]
        public string ObterResumo()
        {
            return $"Pedido #{Numero} | Cliente: {Cliente} | Produtos: R$ {ValorProdutos:F2} | Frete: R$ {ValorFrete:F2} | Total: R$ {CalcularTotal():F2}";
        }
    }
}