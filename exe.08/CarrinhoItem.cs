namespace ExercicioCarrinho
{
    public class CarrinhoItem
    {
        // Propriedades encapsuladas com private set para proteger o estado
        public string Descricao { get; private set; }
        public decimal PrecoUnitario { get; private set; }
        public int Quantidade { get; private set; }

        // Construtor para inicializar o item do carrinho
        public CarrinhoItem(string descricao, decimal precoUnitario, int quantidade)
        {
            Descricao = descricao;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
        }

        // Método sem parâmetros que calcula o subtotal simples
        public decimal CalcularSubtotal()
        {
            return PrecoUnitario * Quantidade;
        }

        // Método que recebe o percentual e usa variáveis locais claras
        public decimal CalcularSubtotalComDesconto(decimal percentualDesconto)
        {
            // Variável local 1: subtotal sem desconto
            decimal subtotal = CalcularSubtotal();

            // Variável local 2: valor calculado do desconto
            decimal valorDesconto = subtotal * (percentualDesconto / 100m);

            // Variável local 3: resultado final com desconto
            decimal subtotalComDesconto = subtotal - valorDesconto;

            return subtotalComDesconto;
        }
    }
}