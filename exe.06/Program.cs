using System;

namespace ExercicioContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Criação do objeto ContaBancaria passando os dados iniciais
            ContaBancaria minhaConta = new ContaBancaria(4231, "Maicon", 1500.00m);

            // Exibindo o estado inicial
            Console.WriteLine("=== SISTEMA BANCÁRIO ===");
            Console.WriteLine($"Titular: {minhaConta.Titular}");
            Console.WriteLine($"Número da Conta: {minhaConta.Numero}");
            Console.WriteLine($"Saldo Inicial: R$ {minhaConta.ConsultarSaldo():F2}\n");

            // 2. Realizando um depósito
            decimal valorDeposito = 500.00m;
            minhaConta.Depositar(valorDeposito);
            Console.WriteLine($"[DEPÓSITO] Realizado com sucesso: R$ {valorDeposito:F2}");
            Console.WriteLine($"Saldo Atual: R$ {minhaConta.ConsultarSaldo():F2}\n");

            // 3. Realizando um saque
            decimal valorSaque = 200.00m;
            minhaConta.Sacar(valorSaque);
            Console.WriteLine($"[SAQUE] Realizado com sucesso: R$ {valorSaque:F2}");
            Console.WriteLine($"Saldo Final: R$ {minhaConta.ConsultarSaldo():F2}");
        }
    }
}