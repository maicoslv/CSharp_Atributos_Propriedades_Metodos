using System;

namespace ExercicioTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância com 25.0 °C
            Temperatura temp = new Temperatura(25.0);

            Console.WriteLine("=== CONVERSOR DE TEMPERATURA ===");
            Console.WriteLine($"Temperatura Original: {temp.Celsius} °C\n");

            // Chamando as conversões
            double fahrenheit = temp.ConverterParaFahrenheit();
            double kelvin = temp.ConverterParaKelvin();

            Console.WriteLine($"Em Fahrenheit: {fahrenheit:F2} °F");
            Console.WriteLine($"Em Kelvin: {kelvin:F2} K");

            // Verificando que o estado original não mudou
            Console.WriteLine($"\nTemperatura após conversões: {temp.Celsius} °C (Estado mantido!)");
        }
    }
}