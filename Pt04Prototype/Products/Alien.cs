namespace Pt04Prototype.Products
{
    public class Alien : AbstructProduct
    {
        public Alien(int id) : base(id)
        {
        }

        public override AbstructProduct Clone()
        {
            return new Alien(id);
        }
    }
}