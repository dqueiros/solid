
using CursoCSharp.InterfaceAbstract.Interfaces;

namespace CursoCSharp.InterfaceAbstract.Abstract
{
    public abstract class AbstractB : IIterfaceB
    {
        public string PropertB { get; set; }

        public abstract void MethodAbstractB1();
        public void MethodAbstractB2()
        {
            throw new NotImplementedException();
        }

        public void MethodB1()
        {
            throw new NotImplementedException();
        }

        public void MethodB2()
        {
            throw new NotImplementedException();
        }
    }
}
