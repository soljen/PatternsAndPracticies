namespace Pt01AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract AbstractWheel BuildWheels(int count);
        public abstract AbstractEngine BuildEngine(int count);
        public abstract AbstractCore BuildCore(int count);
    }
}