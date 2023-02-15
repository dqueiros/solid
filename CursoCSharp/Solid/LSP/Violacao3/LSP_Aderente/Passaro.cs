
namespace Solid.LSP.Violacao3.LSP_Aderente
{
    public  class Passaro
    {
        public string Nome { get; }

        public Passaro(string nome)
        {
            Nome = nome;
        }
        public virtual void Comer()
        {
            Console.WriteLine("\n{Nome} comendo...");
        }
        public virtual void BotarOvos()
        {
            Console.WriteLine($"\n{Nome} botando ovos...");
        }
    }
}
