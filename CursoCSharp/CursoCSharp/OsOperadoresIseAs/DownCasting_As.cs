
namespace CursoCSharp.OsOperadoresIseAs
{
    public class DownCasting_As
    {
        public void Teste()
        {
            Forma f = new Forma();
            Circulo c = f as Circulo;

            if (c != null)
            {
                c.PintarCirculo();
            }
            else
            {
                Console.WriteLine("Operação de downcast inválida (as)");
            }
        }
    }
}
