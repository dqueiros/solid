using Solid.ISP.ISP_Aderente;

CadastrarCliente cliente = new CadastrarCliente();
cliente.ValidarDados();
cliente.SalvarDados();
cliente.EnviarEmail();

CadastrarProduto produto = new CadastrarProduto();
produto.ValidarDados();
produto.SalvarDados();

