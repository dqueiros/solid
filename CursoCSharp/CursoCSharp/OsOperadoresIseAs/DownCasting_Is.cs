
namespace CursoCSharp.OsOperadoresIseAs
{
    public class DownCasting_Is
    {
        public void Teste()
        {
            Circulo circulo = new Circulo();
            Forma f = circulo;

            if (f is Circulo)
            {
                ((Circulo)f).PintarCirculo();
            }
            else
            {
                Console.WriteLine("Operação de downcast inválida (is)");
            }
        }
    }
}
