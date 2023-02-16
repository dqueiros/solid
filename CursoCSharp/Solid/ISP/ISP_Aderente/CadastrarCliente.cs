
namespace Solid.ISP.ISP_Aderente
{
    public class CadastrarCliente : IPersistencia, IMensagemEmail
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
            Console.WriteLine("Valida Dados");
        }
    }
}
