namespace TemperatureConverter;
public class Temperature
{

    private const double MINIMUM_CELSIUS = -273.15;
    private const double MAXIMUM_CELSIUS = 1.417e32;

    private const double MINIMUM_FAHRENHEIT = -459.67;
    private const double MAXIMUM_FAHRENHEIT = 2.55e32;

    private const double MINIMUM_KELVIN = 0.0;
    private const double MAXIMUM_KELVIN = 1.417e32;

    private const int DECIMAL_PLACES = 2;

    public static double ConvertCelsiusToFahrenheit(double temperature)
    {
        if (temperature < MINIMUM_CELSIUS)
            throw new ArgumentOutOfRangeException(nameof(temperature), $"A temperatura não pode ser menor que {MINIMUM_CELSIUS}°C (zero absoluto)");
        
        if (temperature > MAXIMUM_CELSIUS)
            throw new ArgumentOutOfRangeException(nameof(temperature), $"A temperatura não pode ser maior que {MAXIMUM_CELSIUS}°C (temperatura de Planck)");
        
        return double.Round((temperature * 9 / 5) + 32, DECIMAL_PLACES);
    }

    public static double ConvertCelsiusToKelvin(double temperature)
    {
        if (temperature < MINIMUM_CELSIUS)
            throw new ArgumentOutOfRangeException(nameof(temperature), $"A temperatura não pode ser menor que {MINIMUM_CELSIUS}°C (zero absoluto)");

        if (temperature > MAXIMUM_CELSIUS)
            throw new ArgumentOutOfRangeException(nameof(temperature), $"A temperatura não pode ser maior que {MAXIMUM_CELSIUS}°C (temperatura de Planck)");

        return double.Round(temperature + 273.15, DECIMAL_PLACES);
    }

    public static double ConvertFahrenheitToCelsius(double temperature)
    {
        if (temperature < MINIMUM_FAHRENHEIT)
            throw new ArgumentOutOfRangeException(nameof(temperature), $"A temperatura não pode ser menor que {MINIMUM_FAHRENHEIT}°F (zero absoluto)");

        if (temperature > MAXIMUM_FAHRENHEIT)
            throw new ArgumentOutOfRangeException(nameof(temperature), $"A temperatura não pode ser maior que {MAXIMUM_FAHRENHEIT}°F (temperatura de Planck)");

        return double.Round((temperature - 32) * 5 / 9, DECIMAL_PLACES);
    }

    public static double ConvertFahrenheitToKelvin(double temperature)
    {
        if (temperature < MINIMUM_FAHRENHEIT)
            throw new ArgumentOutOfRangeException(nameof(temperature), $"A temperatura não pode ser menor que {MINIMUM_FAHRENHEIT}°F (zero absoluto)");

        if (temperature > MAXIMUM_FAHRENHEIT)
            throw new ArgumentOutOfRangeException(nameof(temperature), $"A temperatura não pode ser maior que {MAXIMUM_FAHRENHEIT}°F (temperatura de Planck)");
        
        return double.Round((temperature - 32) * 5 / 9 + 273.15, DECIMAL_PLACES);
    }

    public static double ConvertKelvinToCelsius(double temperature)
    {
        if (temperature < MINIMUM_KELVIN)
            throw new ArgumentOutOfRangeException(nameof(temperature), $"A temperatura não pode ser menor que {MINIMUM_KELVIN}K (zero absoluto)");

        if (temperature > MAXIMUM_KELVIN)
            throw new ArgumentOutOfRangeException(nameof(temperature), $"A temperatura não pode ser maior que {MAXIMUM_KELVIN}K (temperatura de Planck)");

        return double.Round(temperature - 273.15, DECIMAL_PLACES);
    }

    public static double ConvertKelvinToFahrenheit(double temperature)
    {
        if (temperature < MINIMUM_KELVIN)
            throw new ArgumentOutOfRangeException(nameof(temperature), $"A temperatura não pode ser menor que {MINIMUM_KELVIN}K (zero absoluto)");

        if (temperature > MAXIMUM_KELVIN)
            throw new ArgumentOutOfRangeException(nameof(temperature), $"A temperatura não pode ser maior que {MAXIMUM_KELVIN}K (temperatura de Planck)");

        return double.Round((temperature - 273.15) * 9 / 5 + 32, DECIMAL_PLACES);
    }
}
