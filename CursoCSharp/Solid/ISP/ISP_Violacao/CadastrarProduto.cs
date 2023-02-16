
namespace Solid.ISP.ISP_Violacao
{
    internal class CadastrarProduto : IPersistencia
    {
        public void EnviarEmail()
        {
            Console.WriteLine("Enviar Email");
        }

        public void SalvarDados()
        {
            Console.WriteLine("Salvar Dados");
        }

        public void ValidarDados()
        {
            throw new NotImplementedException();
        }
    }
}
