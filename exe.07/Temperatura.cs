namespace ExercicioTemperatura
{
    public class Temperatura
    {
        // Propriedade encapsulada (com private set para manter o estado protegido)
        public double Celsius { get; private set; }

        // Construtor para inicializar o valor em Celsius
        public Temperatura(double celsius)
        {
            Celsius = celsius;
        }

        // Método que calcula e retorna em Fahrenheit sem alterar o valor de Celsius
        public double ConverterParaFahrenheit()
        {
            return (Celsius * 9.0 / 5.0) + 32.0;
        }

        // Método que calcula e retorna em Kelvin sem alterar o valor de Celsius[cite: 16]
        public double ConverterParaKelvin()
        {
            return Celsius + 273.15;
        }
    }
}