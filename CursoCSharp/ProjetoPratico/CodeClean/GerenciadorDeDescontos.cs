
using ProjetoPratico.CodeClean.Cliente;
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
                precoDepoisDoDesconto = new ClienteNaoRegistrado().AplicarDescontoStatusConta(preco);
                break;
            case StatusContaCliente.ClienteComum:
                precoDepoisDoDesconto = new ClienteComum().AplicarDescontoStatusConta(preco);
                precoDepoisDoDesconto = _descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContasEmAnos);
                break;
            case StatusContaCliente.ClienteEspecial:
                precoDepoisDoDesconto = new ClienteEspecial().AplicarDescontoStatusConta(preco);
                precoDepoisDoDesconto = _descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContasEmAnos);
                break;
            case StatusContaCliente.ClienteVIP:
                precoDepoisDoDesconto = new ClienteVIP().AplicarDescontoStatusConta(preco);
                precoDepoisDoDesconto = _descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContasEmAnos);
                break;
            default:
                throw new NotImplementedException();
        }
        return precoDepoisDoDesconto;
    }
}
