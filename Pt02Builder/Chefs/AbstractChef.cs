using Pt02Builder.Meal;

namespace Pt02Builder.Chefs
{
    public abstract class AbstractChef
    {
        public abstract void AddFirstIngredient();
        public abstract void AddSecondIngredient();
        public abstract void AddThirdIngredient();

        public abstract string GetResult();
    }
}