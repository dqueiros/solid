using ProjetoPratico.CodeSmell;

class Program
{
    public const int CLIENTETIPO1 = 1;
    public const int CLIENTETIPO2 = 2;
    public const int CLIENTETIPO3 = 3;
    public const int CLIENTETIPO4 = 4;

    static void Main(string[] args)
    {
        GerDesc gerdesc = new GerDesc();
        Console.WriteLine("10 anos");
        Console.WriteLine($"Cliente: {CLIENTETIPO1} desconto: {gerdesc.Calcular(1000, CLIENTETIPO1, 10)}");
        Console.WriteLine($"Cliente: {CLIENTETIPO2} desconto: {gerdesc.Calcular(1000, CLIENTETIPO2, 10)}");
        Console.WriteLine($"Cliente: {CLIENTETIPO3} desconto: {gerdesc.Calcular(1000, CLIENTETIPO3, 10)}");
        Console.WriteLine($"Cliente: {CLIENTETIPO4} desconto: {gerdesc.Calcular(1000, CLIENTETIPO4, 10)}");

        Console.WriteLine(new String('-',40));

        Console.WriteLine("10 anos");
        Console.WriteLine($"Cliente: {CLIENTETIPO1} desconto: {gerdesc.Calcular(1000, CLIENTETIPO1, 4)}");
        Console.WriteLine($"Cliente: {CLIENTETIPO2} desconto: {gerdesc.Calcular(1000, CLIENTETIPO2, 4)}");
        Console.WriteLine($"Cliente: {CLIENTETIPO3} desconto: {gerdesc.Calcular(1000, CLIENTETIPO3, 4)}");
        Console.WriteLine($"Cliente: {CLIENTETIPO4} desconto: {gerdesc.Calcular(1000, CLIENTETIPO4, 4)}");
    }
}