namespace Pt04Prototype.Products
{
    public class Robot : AbstructProduct
    {
        public Robot(int id) : base(id)
        {
        }

        public override AbstructProduct Clone()
        {
            return  new Robot(id);
        }
    }
}