
using ProjetoPratico.CodeClean.Interfaces;

namespace ProjetoPratico.CodeClean.Cliente
{
    public class ClienteNaoRegistrado : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco;
        }
    }
}
