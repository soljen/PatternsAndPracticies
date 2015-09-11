namespace Pt01AbstractFactory
{
    class FordWheel : AbstractWheel
    {
        public override int Diameter { get; set; }

        public FordWheel(int diameter)
        {
            Diameter = diameter;
        }
    }
}