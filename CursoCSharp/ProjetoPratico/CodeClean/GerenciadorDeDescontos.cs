
namespace ProjetoPratico.CodeClean;

public partial class GerenciadorDeDescontos
{
    public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContasEmAnos)
    {
        decimal precoAposDesconto = 0;

        decimal descontoPorFidelidade = (tempoDeContasEmAnos > 5) ? 
            (decimal)5 / 100 : 
            (decimal)tempoDeContasEmAnos / 100;

        switch (statusContaCliente)
        {
            case StatusContaCliente.NaoRegistrado:
                precoAposDesconto = precoProduto;
                break;
            case StatusContaCliente.ClienteComum:
                precoAposDesconto = (precoProduto - (0.1m * precoProduto)) - 
                    descontoPorFidelidade * (precoProduto - (0.1m * precoProduto));
                break;
            case StatusContaCliente.ClienteEspecial:
                precoAposDesconto = (0.7m * precoProduto) -
                    descontoPorFidelidade * (0.7m * precoProduto);
                break;
            case StatusContaCliente.ClienteVIP:
                precoAposDesconto = (precoProduto - (0.5m * precoProduto))
                    - descontoPorFidelidade * (precoProduto - (0.5m * precoProduto));
                break;
        }
        return precoAposDesconto;
    }
}
