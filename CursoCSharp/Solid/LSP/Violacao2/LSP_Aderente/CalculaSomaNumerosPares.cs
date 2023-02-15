
namespace Solid.LSP.Violacao2.LSP_Aderente
{
    public class CalculaSomaNumerosPares : Calculadora
    {
        public CalculaSomaNumerosPares(int[] numeros)
            : base(numeros)
        { }

        public override int Calcular() =>
            _numeros.Where(x => x % 2 == 0).Sum();
    }
}
