
namespace CursoCSharp.ArgumentosNomeados
{
    public class Client
    {
        public void EnvarEmail() 
        {
            Email email = new Email();
            email.Enviar(destino: "teste@email.com", assunto: "Assunto", titulo: "Titulo");
            email.Enviar(assunto: "Assunto", titulo: "Titulo",destino: "teste@email.com");
            email.Enviar(titulo: "Titulo", destino: "teste@email.com", assunto: "Assunto");
        }
    }
}
