bool continuar = true;
do
{
    Console.WriteLine("Por favor, insira seu nome:");
    string nome = Console.ReadLine();

    Console.WriteLine("Por favor, insira sua idade:");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Por favor, insira sua altura em metros (por exemplo, 1.75):");
    double altura = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Por favor, insira seu peso em quilogramas:");
    double peso = Convert.ToDouble(Console.ReadLine());

    double imc = peso / (altura * altura); // Calcula do IMC

    // Classifica a categoria do IMC
    string categoriaIMC;
    if (imc < 18.5)
    {
        categoriaIMC = "Abaixo do peso";
    }
    else if (imc >= 18.5 && imc < 25)
    {
        categoriaIMC = "Normal";
    }
    else if (imc >= 25 && imc < 30)
    {
        categoriaIMC = "Sobrepeso";
    }
    else
    {
        categoriaIMC = "Obeso";
    }

    // Clasificação da faixa etária
    string faixaEtaria;
    if (idade < 13)
    {
        faixaEtaria = "Criança";
    }
    else if (idade >= 13 && idade < 20)
    {
        faixaEtaria = "Adolescente";
    }
    else if (idade >= 20 && idade < 60)
    {
        faixaEtaria = "Adulto";
    }
    else
    {
        faixaEtaria = "Idoso";
    }

    // Relatório
    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Idade: {idade}");
    Console.WriteLine($"IMC: {imc:F2} - {categoriaIMC}");
    Console.WriteLine($"Faixa Etária: {faixaEtaria}");

    // Pergunta se quer gerar um novo relatório
    Console.WriteLine("Gostaria de gerar um novo relatório para outra pessoa? (sim/não)");
    continuar = Console.ReadLine().ToLower() == "sim";
} while (continuar);

Console.WriteLine("Programa encerrado.");