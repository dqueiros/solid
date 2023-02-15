
namespace Solid.OCP.OpenClosed.OCP_Aderente
{
    public class DescontoClienteVIP : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal - 100;
        }
    }
}
