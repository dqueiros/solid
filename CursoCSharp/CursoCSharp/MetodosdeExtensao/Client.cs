
using CursoCSharp.MetodosdeExtensao.Utils;

namespace CursoCSharp.MetodosdeExtensao
{
    public class Client
    {
        public void TestaClasse()
        {
            var txt1 = "curso";
            var txt2 = "disciplina";

            txt1 = txt1.CaixaAltaPrimeiraLetra();
            txt2 = txt2.CaixaAltaPrimeiraLetra();
        }
    }
}
