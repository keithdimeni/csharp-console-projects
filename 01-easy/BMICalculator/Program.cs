using BMICalculator;

Console.WriteLine("=== CALCULADORA DE IMC ===");
bool calcularNovamente = true;
do
{
    Console.Write("\nDigite o seu peso(kg): ");
    string peso = Console.ReadLine();
    Console.Write("\nDigite a sua altura(m): ");
    string altura = Console.ReadLine();

    Console.WriteLine("\nCalculando...");

    double pesoIMC = CalculadoraIMC.Peso(peso);
    double alturaIMC = CalculadoraIMC.Altura(altura);
    double imc = CalculadoraIMC.CalcularIMC(pesoIMC, alturaIMC);

    ClassificacaoIMC classificacao = imc switch
    {
        < 18.5 => ClassificacaoIMC.AbaixoDoPeso,
        >= 18.5 and < 25.0 => ClassificacaoIMC.PesoNormal,
        >= 25.0 and < 30.0 => ClassificacaoIMC.Sobrepeso,
        >= 30.0 and 35.0 => ClassificacaoIMC.ObesidadeGrauI,
        >= 35.0 and 40.0 => ClassificacaoIMC.ObesidadeGrauII,
        _ => ClassificacaoIMC.ObesidadeGrauIII,
    };

    string mensagemSaude = classificacao switch
    {
        ClassificacaoIMC.AbaixoDoPeso =>
            "RECOMENDAÇÃO:\n" +
            "Você está abaixo do peso ideal. É importante:\n" +
            "- Consultar um nutricionista\n" +
            "- Aumentar a ingestão calórica de forma saudável\n" +
            "- Realizar exercícios de fortalecimento muscular",

        ClassificacaoIMC.PesoNormal =>
            "PARABÉNS!\n" +
            "Seu peso está dentro da faixa considerada saudável.\n" +
            "Recomendações para manter:\n" +
            "- Mantenha uma alimentação equilibrada\n" +
            "- Continue praticando exercícios regularmente",

        ClassificacaoIMC.Sobrepeso =>
            "ATENÇÃO:\n" +
            "Você está com sobrepeso. Recomendações:\n" +
            "- Ajuste sua dieta com ajuda profissional\n" +
            "- Aumente a prática de exercícios físicos\n" +
            "- Monitore seu peso regularmente",

        ClassificacaoIMC.ObesidadeGrauI =>
            "ALERTA IMPORTANTE:\n" +
            "Você está com Obesidade Grau I. É necessário:\n" +
            "- Procurar acompanhamento médico\n" +
            "- Consultar um nutricionista\n" +
            "- Iniciar um programa de exercícios supervisionado",

        ClassificacaoIMC.ObesidadeGrauII =>
            "ALERTA MÉDICO:\n" +
            "Você está com Obesidade Grau II. Ações necessárias:\n" +
            "- Buscar ajuda médica especializada\n" +
            "- Fazer acompanhamento nutricional regular\n" +
            "- Considerar um programa de emagrecimento estruturado",

        ClassificacaoIMC.ObesidadeGrauIII =>
            "ATENÇÃO URGENTE:\n" +
            "Você está com Obesidade Grau III. É fundamental:\n" +
            "- Procurar atendimento médico imediato\n" +
            "- Realizar exames de saúde completos\n" +
            "- Seguir tratamento multidisciplinar especializado",

        _ => "Classificação não identificada"
    };

    Console.WriteLine("\n=== RESULTADO ===");
    Console.WriteLine($"Peso: {pesoIMC:F2} kg");
    Console.WriteLine($"Altura {alturaIMC:F2} m");
    Console.WriteLine($"IMC: {imc:F2}");
    Console.WriteLine($"Classificação: {classificacao}");
    Console.WriteLine($"\n{mensagemSaude}");

    Console.WriteLine("\nDeseja calcular outro IMC? (s/n): ");
    string resposta = Console.ReadLine().ToLower();
    if (resposta == "s") calcularNovamente = true;
    else
    {
        calcularNovamente = false;
        Console.WriteLine("\nObrigado por esar a Calculadora de IMC!\n");
    }
} while (calcularNovamente);
