using Pt03FactoryMethod.Products;

namespace Pt03FactoryMethod.Farms
{
    class CherryFarm : AbstructFarm
    {
        public override AbstractProduct GrowProduct()
        {
            return new Cherry();
        }
    }
}