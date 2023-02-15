
namespace Solid.LSP.Violacao3.LSP_Aderente
{
    public class PassarosVoadores : Passaro
    {
        public PassarosVoadores(string nome)
            : base(nome)
        {

        }
        public virtual void Voar()
        {
            Console.WriteLine($"\n{Nome} voando...");
        }
    }
}
