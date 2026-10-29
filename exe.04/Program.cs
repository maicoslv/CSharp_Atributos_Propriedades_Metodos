using System;

namespace ExercicioProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia o retângulo com largura 5 e altura 3[cite: 5]
            Retangulo ret = new Retangulo(5.0, 3.0);

            // Realiza os cálculos chamando os métodos
            double area = ret.CalcularArea();
            double perimetro = ret.CalcularPerimetro();

            // Exibe os resultados no console
            Console.WriteLine("--- Dados do Retângulo ---");
            Console.WriteLine($"Largura: {ret.Largura}");
            Console.WriteLine($"Altura: {ret.Altura}");
            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Perímetro: {perimetro}");
        }
    }
}