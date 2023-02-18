using ProjetoPratico.CodeClean.Interfaces;

namespace ProjetoPratico.CodeClean.Cliente
{
    public class ClienteEspecial : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco - (Constantes.DESCONTO_CLIENTE_ESPECIAL * preco);
        }
    }
}
