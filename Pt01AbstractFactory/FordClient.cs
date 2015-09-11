namespace Pt01AbstractFactory
{
    class FordClient
    {
        private AbstractWheel _wheel;
        private AbstractEngine _engine;
        private AbstractCore _core;

        public FordClient(AbstractFactory factory)
        {
            _wheel = factory.BuildWheels(4);
            _engine = factory.BuildEngine(1);
            _core = factory.BuildCore(1);
        }

        public void BuildCar()
        {
            _core.ConnectWheels(_wheel);
            _core.ConnectEngine(_engine);
        }
    }
}