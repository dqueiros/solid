
using System.Reflection.Metadata.Ecma335;

namespace CursoCSharp.ParametrosOpcionais
{
    public class Calcular
    {
        //Parâmetro normal: x
        //Parâmetro Opcional: y, z, w
            //Valor padrão e constante
            //Os parâmetros opcionais deve ser definido após os parametros normais, ou seja,
            //eles são sempre os ultimos parâmetros do método.
        public int Somar(int x, int y = 20, int z = 30, int w = 50)
        {
            return x + y + z + w;
        }
    }
}
