
namespace Solid.DIP.DIP_Aderente
{
    public class RecuperarSenha
    {
        private IDataBaseConnection _conexaoBanco;

        public RecuperarSenha(IDataBaseConnection conexaoBanco)
        {
            _conexaoBanco = conexaoBanco;
        }

        public void ConnectioDb()
        {
            _conexaoBanco.Conectar();
        }

        //codigo para realizar operações
    }
}
