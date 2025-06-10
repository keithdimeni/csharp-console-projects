namespace BMICalculator;
public class CalculadoraIMC
{
    private const double PESO_MINIMO = 2.0;
    private const double PESO_MAXIMO = 650.0;
    private const double ALTURA_MINIMA = 0.20;
    private const double ALTURA_MAXIMA = 2.75;

    public static double Peso(string peso)
    {
        if (peso is null)
            throw new ArgumentNullException(nameof(peso), "O valor do peso não pode ser nulo. Por favor, digite um número válido.");

        bool pesoEValido = double.TryParse(peso, out double pesoEmKilograma);
        if (!pesoEValido)
            throw new ArgumentException($"O peso '{peso}' não é um número válido. Por favor, digite um número válido usando ponto (.) como separador decimal.", nameof(peso));

        if (double.IsNaN(pesoEmKilograma) || double.IsInfinity(pesoEmKilograma))
            throw new ArgumentException("Peso deve ser um número válido", nameof(pesoEmKilograma));

        if (pesoEmKilograma <= 0)
            throw new ArgumentException( "O peso deve ser maior que zero", nameof(pesoEmKilograma));

        if (pesoEmKilograma < PESO_MINIMO)
            throw new ArgumentException( $"O peso informado ({pesoEmKilograma}kg) é menor que mínimo aceitável ({PESO_MINIMO}kg).", nameof(pesoEmKilograma));

        if (pesoEmKilograma > PESO_MAXIMO)
            throw new ArgumentException($"O peso informado ({pesoEmKilograma}kg) é maior que máximo aceitável ({PESO_MINIMO}kg).", nameof(pesoEmKilograma));

        return Math.Round(pesoEmKilograma, 2);
    }

    public static double Altura(string altura)
    {
        if (altura is null)
            throw new ArgumentNullException(nameof(altura), "O valor da altura não pode ser nulo. Por favor, digite um número válido.");

        bool alturaEValida = double.TryParse(altura, out double alturaEmMetro);
        if (!alturaEValida)
            throw new ArgumentException($"A altura '{altura}' não é um número válido. Por favor, digite um número válido usando ponto (.) como separador decimal.", nameof(altura));
        
        if (double.IsNaN(alturaEmMetro) || double.IsInfinity(alturaEmMetro))
             throw new ArgumentException("Altura deve ser um número válido", nameof(alturaEmMetro));

        if (alturaEmMetro <= 0)
            throw new ArgumentException("A altura deve ser maior que zero", nameof(alturaEmMetro));

        if (alturaEmMetro < ALTURA_MINIMA)
            throw new ArgumentException($"A altura informado ({alturaEmMetro:F2}m) é menor que mínimo aceitável ({ALTURA_MINIMA}kg).", nameof(alturaEmMetro));

        if (alturaEmMetro > ALTURA_MAXIMA)
            throw new ArgumentException($"A altura informado ({alturaEmMetro:F2}m) é maior que máximo aceitável ({ALTURA_MAXIMA}kg).", nameof(alturaEmMetro));

        return Math.Round(alturaEmMetro, 2);
    }

    public static double CalcularIMC(double peso, double altura)
    {
        double imc = peso / Math.Pow(altura, 2);
        return Math.Round(imc, 1);
    }

}
