using Pt03FactoryMethod.Products;

namespace Pt03FactoryMethod.Farms
{
    class TomatoFarm : AbstructFarm
    {
        public override AbstractProduct GrowProduct()
        {
            return new Tomato();
        }
    }
}