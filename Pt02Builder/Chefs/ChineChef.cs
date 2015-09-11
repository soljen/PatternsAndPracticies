using System;
using Pt02Builder.Meal;

namespace Pt02Builder.Chefs
{
    public class ChineChef : AbstractChef
    {
        IMeal product = new Tea();

        public override void AddFirstIngredient()
        {
            product.AddInredients("tea");
        }

        public override void AddSecondIngredient()
        {
            product.AddInredients("sugar");
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