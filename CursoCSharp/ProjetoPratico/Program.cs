using ProjetoPratico.CodeClean;
using ProjetoPratico.CodeClean.Interfaces;
using static ProjetoPratico.CodeClean.GerenciadorDeDescontos;

class Program
{
    public const int CLIENTETIPO1 = 1;
    public const int CLIENTETIPO2 = 2;
    public const int CLIENTETIPO3 = 3;
    public const int CLIENTETIPO4 = 4;

    static void Main(string[] args)
    {
        Console.WriteLine("Clean Code");

        ICalculaDescontoFidelidade descFide = 
            new CalculaDescontoFidelidade();

        ICalculaDescontoStatusContaFactory descConta =
            new CalculaDescontoStatusContaFactory();

        GerenciadorDeDescontos gerDesc =
            new GerenciadorDeDescontos(descFide, descConta);

        Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%)\n");

        var resultado1 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 10);
        Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum}, valor do desconto é de : {resultado1}");

        var resultado2 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 10);
        Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial}, valor do desconto é de : {resultado2}");

        var resultado3 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteVIP, 10);
        Console.WriteLine($"Cliente {StatusContaCliente.ClienteVIP}, valor do desconto é de : {resultado3}");

        Console.WriteLine(new String('-',40));

        Console.WriteLine("Valor da compra 1000 e fidelidade 4 anos (5%)\n");

        var resultado4 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 4);
        Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum}, valor do desconto é de : {resultado4}");

        var resultado5 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 4);
        Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial}, valor do desconto é de : {resultado5}");

        var resultado6 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteVIP, 4);
        Console.WriteLine($"Cliente {StatusContaCliente.ClienteVIP}, valor do desconto é de : {resultado6}");

    }
}