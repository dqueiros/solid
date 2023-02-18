using ProjetoPratico.CodeClean.Interfaces;

namespace ProjetoPratico.CodeClean.Cliente
{
    public class ClienteVIP : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco - (Constantes.DESCONTO_CLIENTE_VIP * preco);
        }
    }
}
