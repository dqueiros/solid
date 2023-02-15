
namespace Solid.OCP.OpenClosed.OPC_Violacao
{
    public class Pedido
    {
        public enum TipoCliente
        {
            Comum,
            Associado,
            Especial
        };
        //...outro codigo
        public double DescontoPedido(double valor, TipoCliente tipoCliente)
        {
            double valorFinal;

            if (tipoCliente == TipoCliente.Especial)
            {
                valorFinal = valor - 50;
            }
            else if (tipoCliente == TipoCliente.Associado)
            {
                valorFinal = valor - 10;
            }
            else
            {
                valorFinal = valor;
            }
            return valorFinal;
        }
    }
}
