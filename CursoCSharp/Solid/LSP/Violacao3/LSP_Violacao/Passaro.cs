
namespace Solid.LSP.Violacao3.LSP_Violacao
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

        public virtual void Voar()
        {
            Console.WriteLine($"\n{Nome} voando...");
        }
    }
}
