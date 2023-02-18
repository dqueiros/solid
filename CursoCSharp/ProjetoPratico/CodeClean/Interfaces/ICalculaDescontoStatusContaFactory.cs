
using static ProjetoPratico.CodeClean.GerenciadorDeDescontos;

namespace ProjetoPratico.CodeClean.Interfaces
{
    public interface ICalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoStatusConta GetCalculoDescontoConta(StatusContaCliente statusContaCliente);
    }
}
