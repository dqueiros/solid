
using System.Reflection.Metadata;

namespace Solid.LSP.Violacao2.LSP_Aderente
{
    public abstract class Calculadora
    {
        protected readonly int[] _numeros;

        public Calculadora(int[] numeros)
        {
            _numeros = numeros;
        }

        public abstract int Calcular();
    }
}
