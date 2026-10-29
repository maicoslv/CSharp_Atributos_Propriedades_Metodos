namespace ExercicioProduto
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; private set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public decimal CalcularTotal(int quantidade)
        {
            return Preco * quantidade;
        }

        // Método void que altera o estado da instância (o preço)
        public void AplicarDesconto(decimal percentual)
        {
            // Reduz o preço atual subtraindo a percentagem calculada
            Preco -= Preco * (percentual / 100);
        }
    }
}