namespace ExercicioContaBancaria
{
    public class ContaBancaria
    {
        // Propriedades automáticas com encapsulamento (protegendo a alteração direta de fora)
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }

        // Construtor para inicializar o estado da conta com segurança no nascimento do objeto
        public ContaBancaria(int numero, string titular, decimal saldoInicial)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldoInicial;
        }

        // Método para depositar um valor, alterando o estado do saldo[cite: 14]
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        // Método para sacar um valor, alterando o estado do saldo[cite: 14]
        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        // Método para retornar o saldo atual da conta[cite: 14]
        public decimal ConsultarSaldo()
        {
            return Saldo;
        }
    }
}