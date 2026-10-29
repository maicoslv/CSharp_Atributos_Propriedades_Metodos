namespace ExercicioProduto
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; private set; }

        // Construtor para definir o estado inicial
        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        // Método para calcular o preço total baseado na quantidade
        public decimal CalcularTotal(int quantidade)
        {
            return Preco * quantidade;
        }
    }
}