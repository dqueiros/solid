
namespace Solid.LSP.Violacao2.LSP_Violacao
{
    public class CalculaSoma
    {
        protected readonly int[] _numeros;

        public CalculaSoma(int[] numeros)
        {
            _numeros = numeros;
        }

        public int Calcular() => _numeros.Sum();
    }
}
