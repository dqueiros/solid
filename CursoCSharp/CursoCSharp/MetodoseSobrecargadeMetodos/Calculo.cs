
namespace CursoCSharp.MetodoseSobrecargadeMetodos
{
    public class Calculo
    {
        public int Somar(int num1, int num2) 
        {
            return num1 + num2;
        }

        public double Somar(double num1, int num2)
        {
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Somar(params int[] nums)
        {
            var resultado = 0;
            foreach (var num in nums)
                resultado += num;

            return resultado;

        }
    }
}
