
namespace Solid.OCP.OpenClosed.OCP_Aderente
{
    public class DescontoClienteEspecial : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal - 50;
        }
    }
}
