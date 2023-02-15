
namespace Solid.LSP.Violacao3.LSP_Violacao
{
    public class Pato : Passaro
    {
        public Pato(string nome) 
            : base(nome)
        { }

        public override void Comer()
        {
            Console.WriteLine($"\n{Nome} come milho...");
        }
        public override void BotarOvos()
        {
            Console.WriteLine($"\n{Nome} bota 6 ovos...");
        }
        public override void Voar()
        {
            Console.WriteLine($"\n{Nome} voa baixo...");
        }
    }
}
