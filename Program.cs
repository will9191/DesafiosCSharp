namespace Desafios_C_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Sum();
        IMC();
        Calculator();
    }

    static void Sum()
    {
        var total = 0;
        for (int i = 0; i <= 10; i++)
        {
            total += i;
        }
        Console.WriteLine(total);
        Console.WriteLine("-----------Fim Soma---------");
    }

    static void IMC()
    {
        Console.WriteLine("Vamos calcular seu IMC!");
        Console.WriteLine("");
        Console.WriteLine("Insira seu peso em KG");
        double weight;
        string? weightStr = Console.ReadLine();
        if (weightStr == null)
        {
            Console.WriteLine("Campo nulo!");
            return;
        }
        else if (!double.TryParse(weightStr, out weight))
        {
            Console.WriteLine("Número inválido!");
            return;
        }

        Console.WriteLine("Insira sua altura em metros");
        double height;
        string? heightStr = Console.ReadLine();
        if (heightStr == null)
        {
            Console.WriteLine("Campo Nulo!");
            return;
        }
        else if (!double.TryParse(heightStr, out height))
        {
            Console.WriteLine("Número inválido!");
            return;
        }

        double imc = weight / (height * height);
        switch (imc)
        {
            case < 18.5:
                Console.WriteLine("Você está no índice: Magreza");
                break;
            case >= 18.5 and <= 24.9:
                Console.WriteLine("Você está no índice: Normal");
                break;
            case >= 25 and <= 29.9:
                Console.WriteLine("Você está no índice: Sobrepeso");
                break;
            case >= 30 and <= 34.9:
                Console.WriteLine("Você está no índice: Obesidade grau 1");
                break;
            case >= 35 and <= 39.9:
                Console.WriteLine("Você está no índice: Obesidade grau 2");
                break;
            case > 40:
                Console.WriteLine("Você está no índice: Obesidade grau 3");
                break;
        }
        Console.WriteLine("-----------Fim IMC---------");
    }

    static void Calculator()
    {
        int num1 = 0; int num2 = 0;

        Console.WriteLine("Vamos fazer algumas contas!");

        Console.WriteLine("Digite um número!");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite mais um número!");
        num2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Escolha uma opção da lista para a operação desejada!:");
        Console.WriteLine("\t1 - Somar");
        Console.WriteLine("\t2 - Subtrair");
        Console.WriteLine("\t3 - Multiplicar");
        Console.WriteLine("\t4 - Dividir");
        Console.Write("Opção escolhida: ");

        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine($"O resultado de: {num1} + {num2} = " + (num1 + num2));
                break;
            case "2":
                Console.WriteLine($"O resultado de: {num1} - {num2} = " + (num1 - num2));
                break;
            case "3":
                Console.WriteLine($"O resultado de:{num1} * {num2} = " + (num1 * num2));
                break;
            case "4":
                Console.WriteLine($"O resultado de: {num1} / {num2} = " + (num1 / num2));
                break;
        }
       
        Console.WriteLine("-------Fim da operação!-----------");
    }
}
