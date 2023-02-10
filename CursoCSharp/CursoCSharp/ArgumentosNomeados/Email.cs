
namespace CursoCSharp.ArgumentosNomeados
{
    public class Email
    {
        public void Enviar(string destino, string titulo, string assunto)
        {
            Console.WriteLine($"{destino},{titulo},{assunto}");
        }
    }
}
