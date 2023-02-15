
namespace Solid.LSP.Violacao2.LSP_Violacao
{
    public class CalculaSomaNumerosPares : CalculaSoma
    {
        public CalculaSomaNumerosPares(int[] numeros)
            : base(numeros)
        { }

        public new int Calcular() =>
            _numeros.Where(x => x % 2 == 0).Sum();
    }
}
