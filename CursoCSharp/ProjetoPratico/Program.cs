using ProjetoPratico.CodeSmell;
using ProjetoPratico.CodeClean;


class Program
{
    public const int CLIENTETIPO1 = 1;
    public const int CLIENTETIPO2 = 2;
    public const int CLIENTETIPO3 = 3;
    public const int CLIENTETIPO4 = 4;

    static void Main(string[] args)
    {
        Console.WriteLine("Code Smell");

        GerDesc gerDesc = new GerDesc();
        Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%)\n");

        var resultado1 = gerDesc.Calcular(1000, 2, 10);
        Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade, = {resultado1}");

        var resultado2 = gerDesc.Calcular(1000, 3, 10);
        Console.WriteLine($"Cliente tipo 3, 10 anos fidelidade, = {resultado2}");

        var resultado3 = gerDesc.Calcular(1000, 4, 10);
        Console.WriteLine($"Cliente tipo 4, 10 anos fidelidade, = {resultado3}");

        Console.WriteLine(new String('-',40));

        Console.WriteLine("Valor da compra 1000 e fidelidade 4 anos (5%)\n");

        var resultado4 = gerDesc.Calcular(1000, 2, 4);
        Console.WriteLine($"Cliente tipo 4, 10 anos fidelidade, = {resultado4}");

        var resultado5 = gerDesc.Calcular(1000, 3, 4);
        Console.WriteLine($"Cliente tipo 4, 10 anos fidelidade, = {resultado5}");

        var resultado6 = gerDesc.Calcular(1000, 4, 4);
        Console.WriteLine($"Cliente tipo 4, 10 anos fidelidade, = {resultado6}");



    }
}