namespace ExercicioProduto
{
    public class Retangulo
    {
        // Propriedades com encapsulamento (set privado para proteger o estado)
        public double Largura { get; private set; }
        public double Altura { get; private set; }

        // Construtor para inicializar as dimensões com segurança
        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        // Método sem parâmetros para calcular a área (Largura * Altura)
        public double CalcularArea()
        {
            return Largura * Altura;
        }

        // Método sem parâmetros para calcular o perímetro (2 * (Largura + Altura))
        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }
    }
}