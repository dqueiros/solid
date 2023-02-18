
namespace ProjetoPratico.CodeClean;

public partial class GerenciadorDeDescontos
{
    public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContasEmAnos)
    {
        decimal precoAposDesconto = 0;

        decimal descontoPorFidelidade = (tempoDeContasEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ? 
            (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 : 
            (decimal)tempoDeContasEmAnos / 100;

        switch (statusContaCliente)
        {
            case StatusContaCliente.NaoRegistrado:
                precoAposDesconto = precoProduto;
                break;
            case StatusContaCliente.ClienteComum:
                precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_COMUM * precoProduto)) - 
                    descontoPorFidelidade * (precoProduto - (Constantes.DESCONTO_CLIENTE_COMUM * precoProduto));
                break;
            case StatusContaCliente.ClienteEspecial:
                precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_ESPECIAL * precoProduto)) - 
                    descontoPorFidelidade * (precoProduto - (Constantes.DESCONTO_CLIENTE_ESPECIAL * precoProduto)); break;
            case StatusContaCliente.ClienteVIP:
                precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_VIP * precoProduto)) - 
                    descontoPorFidelidade * (precoProduto - (Constantes.DESCONTO_CLIENTE_VIP * precoProduto));
                break;
            default:
                throw new NotImplementedException();
        }
        return precoAposDesconto;
    }
}
