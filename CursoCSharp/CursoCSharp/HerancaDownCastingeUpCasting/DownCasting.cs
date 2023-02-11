
namespace CursoCSharp.HerancaDownCastingeUpCasting
{
    public class DownCasting
    {
        public void Test()
        {
            Circulo circulo = new Circulo();
            Forma f = circulo;

            Circulo c = (Circulo)f;

            Console.WriteLine(c == f);
            Console.WriteLine(c == circulo);

            c.Desenhar();
            c.PintarCirculo();
        }
    }
}
