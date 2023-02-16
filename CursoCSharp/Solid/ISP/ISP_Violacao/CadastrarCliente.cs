
namespace Solid.ISP.ISP_Violacao
{
    public class CadastrarCliente : IPersistencia
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
