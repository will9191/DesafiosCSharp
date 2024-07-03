namespace Desafios_C_.src
{
    public class IMC
    {
        public static void Method()
        {
            Console.WriteLine("-----------Início IMC---------");
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
            Console.WriteLine("-----------Fim IMC---------");Console.WriteLine();
        }
    }
}