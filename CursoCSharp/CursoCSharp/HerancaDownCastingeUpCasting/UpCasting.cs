
namespace CursoCSharp.HerancaDownCastingeUpCasting
{
    public class UpCasting
    {
        public void Test()
        {
            Circulo circulo = new Circulo();
            Forma f = circulo;

            Console.WriteLine(f == circulo);

            f.Desenhar();

            //Não é possivel utilizar o método PintarCirculo
            //f.PintarCirculo();
        }
    }
}
