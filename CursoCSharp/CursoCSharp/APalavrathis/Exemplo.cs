
namespace CursoCSharp.APalavraThis
{
    public class Exemplo
    {
        public string Nome { get; set; }
        public Exemplo(string nome)
        {
            this.Nome = nome;

            Teste teste = new Teste(this);

            Console.WriteLine(teste.Nome);
        }
    }
}
