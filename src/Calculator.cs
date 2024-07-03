namespace Desafios_C_.src
{
    public class Calculator
    {
        public static void Method()
        {
            Console.WriteLine("-----------Início Calculadora---------");
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

            Console.WriteLine("-------Fim Calculadora-----------");
            Console.WriteLine();
        }
    }
}