namespace AlunoMedia
{
    public class Aluno
    {
        // Propriedades encapsuladas com private set (proteção dos dados)
        public string Nome { get; private set; }
        public double Nota1 { get; private set; }
        public double Nota2 { get; private set; }

        // Construtor para definir o estado inicial do Aluno
        public Aluno(string nome, double nota1, double nota2)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
        }

        // Método que calcula a média aritmética
        public double CalcularMedia()
        {
            return (Nota1 + Nota2) / 2.0;
        }

        // Método que chama o outro método da própria classe (Reuso de código!)[cite: 6]
        public string ObterSituacao()
        {
            double media = CalcularMedia();

            if (media >= 7.0)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}