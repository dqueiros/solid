using Solid.ISP.ISP_Violacao;
using Solid.LSP.Violacao3.LSP_Aderente;

CadastrarCliente cliente = new CadastrarCliente();
cliente.ValidarDados();
cliente.SalvarDados();
cliente.EnviarEmail();

CadastrarProduto produto = new CadastrarProduto();
produto.ValidarDados();
produto.SalvarDados();
produto.EnviarEmail();

