namespace FactorySimple
{
    public abstract class BaseCalculator
    {
        public int A { get; set; }

        public int B { get; set; }

        public abstract int GetResult();
    }
}
