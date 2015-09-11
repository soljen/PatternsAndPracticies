namespace Pt01AbstractFactory
{
    abstract class AbstractCore
    {
        public abstract void ConnectWheels(AbstractWheel wheels);
        public abstract void ConnectEngine(AbstractEngine engine);
    }
}