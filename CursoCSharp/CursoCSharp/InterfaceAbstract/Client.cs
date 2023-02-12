
using CursoCSharp.InterfaceAbstract.Concret;

namespace CursoCSharp.InterfaceAbstract
{
    public class Client
    {
        public void Executar()
        {
            ConcretA concretA = new ConcretA();
            concretA.MethodA1();
            concretA.MethodA2();
            concretA.MethodAbstractA1();
            concretA.MethodAbstractA2();

            ConcretB concretB = new ConcretB();
            concretB.MethodB1();
            concretB.MethodB2();
            concretB.MethodAbstractB1();
            concretB.MethodAbstractB2();

            concretB.PropertB = "PropertB";
            var result = concretB.PropertB;
        }
    }
}
