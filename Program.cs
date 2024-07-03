namespace Desafios_C_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Sum();
      
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


}
