namespace Pt04Prototype.Products
{
    public abstract class AbstructProduct
    {
        public int id { get; private set; }

        public AbstructProduct(int id)
        {
            this.id = id;
        }

        public abstract AbstructProduct Clone();
    }
}