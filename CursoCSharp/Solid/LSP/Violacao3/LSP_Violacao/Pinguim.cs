
namespace Solid.LSP.Violacao3.LSP_Violacao
{
    public class Pinguim : Passaro
    {
        public Pinguim(string nome) 
            : base(nome)
        { }

        public override void Comer()
        {
            Console.WriteLine($"\n{Nome} come peixes...");
        }
        public override void BotarOvos()
        {
            Console.WriteLine($"\n{Nome} bota 2 ovos...");
        }

        public override void Voar() =>
            throw new Exception("Pinguins não podem voar...");
        
    }
}
