using System;

namespace ExercicioContador
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando o contador
            Contador meuContador = new Contador();

            Console.WriteLine("=== SISTEMA DE CONTADOR ===");
            Console.WriteLine($"Valor Inicial: {meuContador.Quantidade}\n");

            // Testando o método Incrementar()
            Console.WriteLine("-> Chamando Incrementar() 3 vezes...");
            meuContador.Incrementar();
            meuContador.Incrementar();
            meuContador.Incrementar();
            Console.WriteLine($"Quantidade Atual: {meuContador.Quantidade}\n");

            // Testando o método Adicionar(int quantidade)
            Console.WriteLine("-> Chamando Adicionar(10)...");
            meuContador.Adicionar(10);
            Console.WriteLine($"Quantidade Atual: {meuContador.Quantidade}\n");

            Console.WriteLine("-> Chamando Adicionar(5)...");
            meuContador.Adicionar(5);
            Console.WriteLine($"Quantidade Final: {meuContador.Quantidade}");

            // Tentar alterar diretamente meuContador.Quantidade = 50; daria ERRO de compilação!
        }
    }
}