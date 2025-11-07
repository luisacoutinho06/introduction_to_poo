namespace IntroductionToPoo;
internal class Program
{
    static void Main(string[] args)
    {
        //VariaveisETipos();
        //OperadoresAritmeticos();
        //OperadoresComparacao();
        //OperadoresLogicos();
        //OperadoresAtribuicao();
        //EstruturasCondicionais();
        //LacosRepeticao();


    }

    // 1. Variáveis e Tipos de Dados
    static void VariaveisETipos()
    {
        string nome = "João da Silva";
        int idade = 29;
        double altura = 1.79;
        decimal salario = 1965.89m;
        bool estudante = true;

        Console.WriteLine("1. Variáveis e Tipos de Dados:");
        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura}, Salário: {salario}, Estudante: {(estudante ? "Sim (true)" : "Não (false)")}\n");
    }

    // 2. Operadores Aritméticos e Incrementos/Decrementos
    static void OperadoresAritmeticos()
    {
        int a = 10;
        int b = 3;

        Console.WriteLine("2. Operadores Aritméticos");
        Console.WriteLine($"Soma: {a + b}");
        Console.WriteLine($"Subtrtação: {a - b}");
        Console.WriteLine($"Multiplicação: {a * b}");
        Console.WriteLine($"Divisão: {a / b}");
        Console.WriteLine($"Resto: {a % b}");

        // Incremento e Decremento
        int x = 5;
        Console.Write($"Valor inicial de x: {x}. \n");

        x++;
        Console.Write($"Valor de x pós-incremento: {x}.\n");

        x--;
        Console.Write($"Valor de x pós-decremento: {x}.");
    }

    // 3. Operadores de Comparação
    static void OperadoresComparacao()
    {
        int x = 10;
        int y = 20;

        Console.WriteLine("3. Operadores de Comparação");
        Console.WriteLine($"x == y : {x == y}"); // comparação de igualdade (==)
        Console.WriteLine($"x != y : {x != y}"); // verificando se é diferente (!=)
        Console.WriteLine($"x > y : {x > y}");   // maior que
        Console.WriteLine($"x < y : {x < y}");   // menor que
        Console.WriteLine($"x >= y : {x >= y}"); // maior ou igual 
        Console.WriteLine($"x <= y : {x <= y}"); // menor ou igual
    }

    // 4. Operadores Lógicos
    static void OperadoresLogicos()
    {
        // Operadores Lógicos
        // AND (&&) → todas as condições precisam ser verdadeiras
        // OR  (||) → pelo menos uma condição precisa ser verdadeira
        // NOT (!)  → inverte o resultado lógico

        int idade = 37;
        string sexo = "masculino";
        bool possuiDoencaGrave = false;
        bool contribuicaoSuficiente = true;

        Console.WriteLine("4. Operadores Lógicos");

        // Exemplo com AND (&&)
        if (idade >= 65 && sexo == "masculino")
            Console.WriteLine("Pode aposentar (homem com 65 anos ou mais).");
        else if (idade >= 62 && sexo == "feminino")
            Console.WriteLine("Pode aposentar (mulher com 62 anos ou mais).");
        else
            Console.WriteLine("Não pode aposentar por idade.");

        // Exemplo com OR (||)
        if (idade >= 60 || possuiDoencaGrave)
            Console.WriteLine("Pode solicitar análise especial de aposentadoria.");
        else
            Console.WriteLine("Não atende aos requisitos para análise especial.");

        // Exemplo com NOT (!)
        if (!contribuicaoSuficiente)
            Console.WriteLine("Não possui tempo suficiente de contribuição.");
        else
            Console.WriteLine("Tempo de contribuição suficiente.");

        // Combinação de operadores
        if ((idade >= 60 && contribuicaoSuficiente) || possuiDoencaGrave)
            Console.WriteLine("Aposentadoria antecipada possível!");
        else
            Console.WriteLine("Ainda não cumpre requisitos para aposentadoria antecipada.");
    }

    // 5. Operadores de Atribuição
    static void OperadoresAtribuicao()
    {
        int num = 10;

        Console.WriteLine("5. Operadores de Atribuição");
        Console.WriteLine($"Valor inicial: {num}");

        num += 5; // num = num + 5
        Console.WriteLine($"num += 5 -> {num}");

        num -= 2; // num = num - 2
        Console.WriteLine($"num -= 2 -> {num}");

        num *= 3; // num = num * 3
        Console.WriteLine($"num *= 3 -> {num}");

        num /= 4; // num = num / 4
        Console.WriteLine($"num /= 4 -> {num}");
    }

    // 6. Estruturas Condicionais
    static void EstruturasCondicionais()
    {
        int numero = 10;
        int outroNumero = 5;
        string texto = "Exemplo";

        Console.WriteLine("6. Estruturas Condicionais\n");

        if (numero > outroNumero)
        {
            Console.WriteLine($"{numero} é maior que {outroNumero}");
        }
        else if (numero < outroNumero)
        {
            Console.WriteLine($"{numero} é menor que {outroNumero}");
        }
        else
        {
            Console.WriteLine($"{numero} e {outroNumero} são iguais");
        }

        switch (texto)
        {
            case "Teste":
                Console.WriteLine("O texto é 'Teste'");
                break;

            case "Exemplo":
                Console.WriteLine("O texto é 'Exemplo'");
                break;

            case "Outro":
                Console.WriteLine("O texto é 'Outro'");
                break;

            default:
                Console.WriteLine("Texto não reconhecido");
                break;
        }
    }

    // 7. Laços de Repetição
    static void LacosRepeticao()
    {
        Console.WriteLine("7. Laços de Repetição\n");

        // Exemplo de FOR
        Console.WriteLine("Exemplo de FOR:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Contagem: {i}");
        }

        Console.WriteLine();

        // Exemplo de WHILE
        Console.WriteLine("Exemplo de WHILE:");
        int contador = 1;
        while (contador <= 5)
        {
            Console.WriteLine($"Valor do contador: {contador}");
            contador++;
        }

        Console.WriteLine();

        // Exemplo de DO WHILE
        Console.WriteLine("Exemplo de DO WHILE:");
        int numero = 1;
        do
        {
            Console.WriteLine($"Número atual: {numero}");
            numero++;
        } while (numero <= 5);

        Console.WriteLine();

        // Exemplo de FOREACH
        Console.WriteLine("Exemplo de FOREACH:");
        string[] frutas = { "Maçã", "Banana", "Laranja", "Uva" };

        foreach (string fruta in frutas)
        {
            Console.WriteLine($"Fruta: {fruta}");
        }
    }
}