using System;
using Pt02Builder.Meal;

namespace Pt02Builder.Chefs
{
    public class UkrainianChef : AbstractChef
    {
        IMeal product = new Soup();

        public override void AddFirstIngredient()
        {
            product.AddInredients("potato");
        }

        public override void AddSecondIngredient()
        {
            product.AddInredients("carrot");
        }

        public override void AddThirdIngredient()
        {
            product.AddInredients("water");
        }

        public override string GetResult()
        {
            return product.GetResult();
        }
    }
}