namespace Pt01AbstractFactory
{
    class FordEngine : AbstractEngine
    {
        public override int Volume { get; set; }

        public FordEngine(int volume)
        {
            Volume = volume;
        }
    }
}