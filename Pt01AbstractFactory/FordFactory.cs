namespace Pt01AbstractFactory
{
    class FordFactory : AbstractFactory
    {
        public override AbstractWheel BuildWheels(int count)
        {
            return new FordWheel(17);
        }

        public override AbstractEngine BuildEngine(int count)
        {
            return new FordEngine(2000);
        }

        public override AbstractCore BuildCore(int count)
        {
            return new FordCore();
        }
    }
}