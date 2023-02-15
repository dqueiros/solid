
namespace Solid.OCP.OpenClosed.OCP_Aderente
{
    public class DescontoClienteAssociando : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal - 10;
        }
    }
}
