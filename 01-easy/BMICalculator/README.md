# 📊 Calculadora de IMC - Aplicação Console

Uma aplicação console em C# que calcula o Índice de Massa Corporal (IMC) e fornece classificação de saúde baseada nos padrões da OMS.

## 🎯 Objetivos do Projeto

Este projeto ajuda a desenvolver habilidades em:
- Validação e tratamento de entrada do usuário
- Cálculos matemáticos básicos
- Implementação de lógica condicional
- Formatação de saída de dados
- Tratamento de exceções
- Controle de fluxo do programa
- Aplicação de padrões de saúde internacionais

## ✨ Funcionalidades

- ✅ Solicita peso e altura do usuário
- ✅ Calcula IMC usando a fórmula: `peso / (altura²)`
- ✅ Classifica resultado conforme padrões da OMS
- ✅ Exibe resultado formatado com 2 casas decimais
- ✅ Valida entrada para valores positivos
- ✅ Trata entradas inválidas com mensagens de erro
- ✅ Opção de calcular múltiplos IMCs
- ✅ Interface clara e amigável ao usuário
- ✅ Exibe informações educativas sobre IMC

## 📋 Tabela de Classificação do IMC

| Faixa de IMC | Classificação |
|--------------|---------------|
| Abaixo de 18,5 | Abaixo do peso |
| 18,5 - 24,9 | Peso normal |
| 25,0 - 29,9 | Sobrepeso |
| 30,0 - 34,9 | Obesidade Grau I |
| 35,0 - 39,9 | Obesidade Grau II |
| 40,0 ou mais | Obesidade Grau III |

## 🚀 Como Executar

### Pré-requisitos
- .NET 8.0 SDK ou superior
- IDE ou editor de código (Visual Studio, Rider, VS Code, etc.)

### Passos para Execução
1. **Clone o repositório**
   ```bash
   git clone https://github.com/keithdimeni/csharp-console-projects.git
   ```

2. **Navegue até o diretório do projeto**
   ```bash
   cd csharp-console-projects/01-easy/BMICalculator
   ```

3. **Execute a aplicação**
   ```bash
   dotnet run
   ```

## 🔍 Conceitos Técnicos Aprendidos

### Conceitos de Programação
- **Entrada do usuário**: `Console.ReadLine()`
- **Conversão de tipos**: `double.TryParse()`, `Convert.ToDouble()`
- **Operações matemáticas**: `Math.Pow()` para exponenciação
- **Formatação de strings**: `"F2"` para casas decimais
- **Estruturas condicionais**: cadeias `if-else, switch expression`
- **Loops**: `do-while` para repetição do programa
- **Tratamento de exceções**: com `throw`


## 🏷️ Tags

`csharp` `console` `imc` `saude` `iniciante` `matematica` `dotnet` `algoritmos`

---

**Nível de Dificuldade**: 🟢 Fácil  
**Pré-requisitos**: Sintaxe básica de C# e conceitos de programação  
**Habilidades Desenvolvidas**: Validação de entrada, cálculos matemáticos, lógica condicional