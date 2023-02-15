using Solid.OCP.OpenClosed.OCP_Aderente;

Pedido pedidoVip= new DescontoClienteVIP();
Console.WriteLine($"Desconto cliente VIP : {pedidoVip.DescontoPedido(200).ToString("C")}");

Pedido pedidoAssociado = new DescontoClienteAssociando();
Console.WriteLine($"Desconto cliente Associado : {pedidoAssociado.DescontoPedido(200).ToString("C")}");

Pedido pedidoEspecial = new DescontoClienteEspecial();
Console.WriteLine($"Desconto cliente Espcial : {pedidoEspecial.DescontoPedido(200).ToString("C")}");





