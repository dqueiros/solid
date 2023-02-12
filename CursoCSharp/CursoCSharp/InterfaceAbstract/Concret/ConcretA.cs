
using CursoCSharp.InterfaceAbstract.Abstract;
using CursoCSharp.InterfaceAbstract.Interfaces;

namespace CursoCSharp.InterfaceAbstract.Concret
{
    public class ConcretA : AbstractA, IIterfaceA
    {
        public void MethodA1()
        {
            throw new NotImplementedException();
        }

        public void MethodA2()
        {
            throw new NotImplementedException();
        }

        public override void MethodAbstractA1()
        {
            throw new NotImplementedException();
        }
    }
}
