
using ProjetoPratico.CodeClean.Interfaces;
using System.Runtime.CompilerServices;

namespace ProjetoPratico.CodeClean;

public partial class GerenciadorDeDescontos
{
            private readonly ICalculaDescontoFidelidade _descontoFidelidade;

        public GerenciadorDeDescontos(ICalculaDescontoFidelidade descontoFidelidade)
        {
            _descontoFidelidade = descontoFidelidade;
        }

    public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente, int tempoDeContasEmAnos)
    {

        decimal precoDepoisDoDesconto = 0;

        switch (statusContaCliente)
        {
            case StatusContaCliente.NaoRegistrado:
                precoDepoisDoDesconto = preco;
                break;
            case StatusContaCliente.ClienteComum:
                precoDepoisDoDesconto = (preco - (Constantes.DESCONTO_CLIENTE_COMUM * preco));
                precoDepoisDoDesconto = 
                    _descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContasEmAnos);
                break;
            case StatusContaCliente.ClienteEspecial:
                precoDepoisDoDesconto = (preco - (Constantes.DESCONTO_CLIENTE_ESPECIAL * preco));
                precoDepoisDoDesconto =
                    _descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContasEmAnos);
                break;
            case StatusContaCliente.ClienteVIP:
                precoDepoisDoDesconto = (preco - (Constantes.DESCONTO_CLIENTE_VIP * preco));
                precoDepoisDoDesconto =
                    _descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContasEmAnos);
                break;
            default:
                throw new NotImplementedException();
        }
        return precoDepoisDoDesconto;
    }
}
