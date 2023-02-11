
namespace CursoCSharp.HerancaDownCastingeUpCasting
{
    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenha Circulo");
        }

        public void PintarCirculo()
        {
            Console.WriteLine("Pintando o círculo");
        }
    }
}
