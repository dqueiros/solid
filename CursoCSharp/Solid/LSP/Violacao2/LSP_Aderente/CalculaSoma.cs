
namespace Solid.LSP.Violacao2.LSP_Aderente;

public class CalculaSoma : Calculadora
{
    protected readonly int[] _numeros;

    public CalculaSoma(int[] numeros)
        : base(numeros)
    {
        _numeros = numeros;
    }

    public override int Calcular() => _numeros.Sum();
}
