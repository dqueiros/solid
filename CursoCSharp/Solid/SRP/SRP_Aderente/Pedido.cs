
using System.Net.Mail;

namespace Solid.SRP.SRP_Aderente
{
    public class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }
        private ILogger infoLogger;
        private EnviarEmail enviaEmail;

        public Pedido()
        {
            infoLogger = new RegistraLog();
            enviaEmail = new EnviarEmail();
        }

        public void IncluirPedido()
        {
            try
            {
                infoLogger.Info("Incluido um pedido");
                
                enviaEmail.EMailFrom = "emailfrom@xyz.com";
                enviaEmail.EMailTo = "emailto@xyz.com";
                enviaEmail.EMailSubject = "SRP";
                enviaEmail.EMailBody = "Um";
                enviaEmail.Enviar();

            }
            catch (Exception ex)
            {
                infoLogger.Info("Erro ao enviar email : " + ex.Message);
            }
        }
        public void DeletaPedido()
        {
            try
            {
                infoLogger.Info("Pedido deletado em " + DateTime.Now);
            }
            catch (Exception ex)
            {
                infoLogger.Info("Erro ao deletar pedido : " + ex.Message);
            }
        }
    }
}