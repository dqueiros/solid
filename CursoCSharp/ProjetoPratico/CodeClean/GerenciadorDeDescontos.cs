
using ProjetoPratico.CodeClean.Cliente;
using ProjetoPratico.CodeClean.Interfaces;
using System.Runtime.CompilerServices;

namespace ProjetoPratico.CodeClean;

public partial class GerenciadorDeDescontos
{
    private readonly ICalculaDescontoFidelidade _descontoFidelidade;
    private readonly ICalculaDescontoStatusContaFactory _descontoStatusConta;
    public GerenciadorDeDescontos(ICalculaDescontoFidelidade descontoFidelidade, ICalculaDescontoStatusContaFactory descontoStatusConta)
    {
        _descontoFidelidade = descontoFidelidade;
        _descontoStatusConta = descontoStatusConta;
    }

    public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente, int tempoDeContasEmAnos)
    {

        decimal precoDepoisDoDesconto = 0;

        precoDepoisDoDesconto = 
            _descontoStatusConta.GetCalculoDescontoConta(statusContaCliente).AplicarDescontoStatusConta(preco);

        precoDepoisDoDesconto = _descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContasEmAnos);
        return precoDepoisDoDesconto;
    }
}
