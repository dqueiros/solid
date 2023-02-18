
using ProjetoPratico.CodeClean.Cliente;
using ProjetoPratico.CodeClean.Interfaces;
using static ProjetoPratico.CodeClean.GerenciadorDeDescontos;

namespace ProjetoPratico.CodeClean
{
    public class CalculaDescontoStatusContaFactory : ICalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoStatusConta GetCalculoDescontoConta(GerenciadorDeDescontos.StatusContaCliente statusContaCliente)
        {
            ICalculaDescontoStatusConta calcular;
            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    calcular = new ClienteNaoRegistrado();
                    break;
                case StatusContaCliente.ClienteComum:
                    calcular = new ClienteComum();
                    break;
                case StatusContaCliente.ClienteEspecial:
                    calcular = new ClienteEspecial();
                    break;
                case StatusContaCliente.ClienteVIP:
                    calcular = new ClienteVIP();
                    break;
                default:
                    throw new NotImplementedException();
            }
            return calcular;
        }
    }
}
