namespace Desafios_C_.src
{
    public class Sum
    {
        public static void Method()
        {
            Console.WriteLine("-----------Início Soma---------");
            var total = 0;
            for (int i = 0; i <= 10; i++)
            {
                total += i;
            }
            Console.WriteLine(total);
            Console.WriteLine("-----------Fim Soma---------"); Console.WriteLine();
        }
    }
}