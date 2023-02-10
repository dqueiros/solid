
namespace CursoCSharp.MetodosdeExtensao.Utils
{
    public static class MetodosExtensao
    {
        public static string CaixaAltaPrimeiraLetra(this string value)
        {
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }

            return value;
        }
    }
}
