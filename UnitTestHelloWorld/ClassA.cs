namespace UnitTestHelloWorld
{
    public class ClassA
    {
        private IClassB _classB;

        public ClassA()
            :this(new ClassB))
        {
        }

        internal ClassA(IClassB)
        {
            _classB = classB;
        }

        public strng DoSomehingA()
        {
            return _classB.GetData();
        }
    }
}