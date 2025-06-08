using BasicCalculator;


bool continuarExecutando = true;
do
{
    Console.Clear();
    Console.WriteLine("=============Calculadora Básica=============");

    Console.Write("\nDigite o primeiro numero: ");
    var value1 = Console.ReadLine();

    if (value1 is null)
        throw new ArgumentNullException(nameof(value1), "O primeiro número não pode ser nulo");

    if (!int.TryParse(value1, out int num1))
    {
        Console.WriteLine("Valor inválido, digite números inteiros válido.");
        return;
    }

    Console.Write("\nDigite o segundo numero: ");
    var value2 = Console.ReadLine();

    if (value2 is null)
        throw new ArgumentNullException(nameof(value2), "O segundo número não pode ser nulo");

    if (!int.TryParse(value2, out int num2))
    {
        Console.WriteLine("Valor inválido, digite números inteiros válido.");
        return;
    }


    Console.WriteLine("Selecione a operação desejada: \n1-Adição\n2-Subtração\n3-Multiplicação\n4-Divisão\n0-Sair");
    string? operacao = Console.ReadLine();
    if (operacao is null)
        throw new ArgumentNullException(nameof(operacao), "A operação não pode ser nulo");

    int resultado;
    switch (operacao)
    {
        case "1":
            resultado = Calculadora.Somar(num1, num2);
            Console.WriteLine($"\nResultado: {resultado}");
            break;
        case "2":
            resultado = Calculadora.Subtrair(num1, num2);
            Console.WriteLine($"\nResultado: {resultado}");
            break;
        case "3":
            resultado = Calculadora.Multiplicar(num1, num2);
            Console.WriteLine($"\nResultado: {resultado}");
            break;
        case "4":
            resultado = Calculadora.Dividir(num1, num2);
            Console.WriteLine($"\nResultado: {resultado}");
            break;
        case "0":
            Environment.Exit(Environment.ExitCode);
            break;
        default:
            Console.WriteLine("\nOperação inválida");
            break;
    }

    Console.Write("\n\nDeseja continuar? (S/N): ");
    var resposta = Console.ReadLine()?.ToUpper();
    continuarExecutando = resposta == "S";


} while (continuarExecutando);