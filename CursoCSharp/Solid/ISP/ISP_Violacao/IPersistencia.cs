
namespace Solid.ISP.ISP_Violacao
{
    public interface IPersistencia
    {
        void ValidarDados();
        void SalvarDados();
        void EnviarEmail();
    }
}
