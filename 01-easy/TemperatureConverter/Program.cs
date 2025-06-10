using TemperatureConverter;

Console.WriteLine("=== CONVERSOR DE TEMPERATURAS ===");
bool continueProgram = true;
do
{
    Console.Clear();
    Console.WriteLine("\nEscolha uma opção: ");
    Console.WriteLine("1 - Celsius para Fahrenheit");
    Console.WriteLine("2 - Celsius para Kelvin");
    Console.WriteLine("3 - Fahrenheit para Celsius");
    Console.WriteLine("4 - Fahrenheit para Kelvin");
    Console.WriteLine("5 - Kelvin para Celsius");
    Console.WriteLine("6 - Kelvin para Fahrenheit");
    Console.WriteLine("0 - Sair");

    Console.Write("\nDigite sua opção: ");
    string? option = Console.ReadLine();
    if (option is null)
    {
        Console.WriteLine("Opção inválida! Por favor, digite um número.");
        continue;
    }

    switch (option)
    {
        case "1":
            double celsius = ReadTemperatureInput("Celsius");
            if (!double.IsNaN(celsius))
            {
                double fahrenheit = Temperature.ConvertCelsiusToFahrenheit(celsius);
                DisplayConversion(celsius, fahrenheit, "ºC", "ºF");
            }
            break;
        case "2":
            double celsiusToKelvin = ReadTemperatureInput("Celsius");
            if (!double.IsNaN(celsiusToKelvin))
            {
                double kelvin = Temperature.ConvertCelsiusToKelvin(celsiusToKelvin);
                DisplayConversion(celsiusToKelvin, kelvin, "ºC", "K");
            }
            break;
        case "3":
            double fahrenheitToCelsius = ReadTemperatureInput("Fahrenheit");
            if (!double.IsNaN(fahrenheitToCelsius))
            {
                double celsiusConverted = Temperature.ConvertFahrenheitToCelsius(fahrenheitToCelsius);
                DisplayConversion(fahrenheitToCelsius, celsiusConverted, "ºF", "ºC");
            }
            break;
        case "4":
            double fahrenheitToKelvin = ReadTemperatureInput("Fahrenheit");
            if (!double.IsNaN(fahrenheitToKelvin))
            {
                double kelvinConverted = Temperature.ConvertFahrenheitToKelvin(fahrenheitToKelvin);
                DisplayConversion(fahrenheitToKelvin, kelvinConverted, "ºF", "K");
            }
            break;
        case "5":
            double kelvinToCelsius = ReadTemperatureInput("Kelvin");
            if (!double.IsNaN(kelvinToCelsius))
            {
                double celsiusFromKelvin = Temperature.ConvertKelvinToCelsius(kelvinToCelsius);
                DisplayConversion(kelvinToCelsius, celsiusFromKelvin, "K", "ºC");
            }
            break;
        case "6":
            double kelvinToFahrenheit = ReadTemperatureInput("Kelvin");
            if (!double.IsNaN(kelvinToFahrenheit))
            {
                double fahrenheitFromKelvin = Temperature.ConvertKelvinToFahrenheit(kelvinToFahrenheit);
                DisplayConversion(kelvinToFahrenheit, fahrenheitFromKelvin, "K", "ºF");
            }
            break;
        case "0":
            Environment.Exit(Environment.ExitCode);
            break;
        default:
            Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida.");
            break;
    }

    Console.WriteLine("Deseja realizar outra conversão? (s/n): ");
    string? response = Console.ReadLine()?.ToLower();
    if (response == "s")
        continueProgram = true;
    else
    {
        continueProgram = false;
        Console.WriteLine("Obrigado por usar o Conversor de Temperaturas!");
    }

} while (continueProgram);

static double ReadTemperatureInput(string unit)
{
    Console.Write($"Digite a temperatura em {unit}: ");
    string? input = Console.ReadLine();

    if (input is null)
    {
        Console.WriteLine("Temperatura inválida! Por favor, digite um número.");
        return double.NaN;
    }

    if (!double.TryParse(input, out double temperature))
    {
        Console.WriteLine("Valor inválido! Por favor digite um número válido.");
        return double.NaN;
    }

    return temperature;
}

static void DisplayConversion(double inputTemp, double convertedTemp, string fromUnit, string toUnit)
{
    Console.WriteLine($"{inputTemp}{fromUnit} = {convertedTemp}{toUnit}");
}