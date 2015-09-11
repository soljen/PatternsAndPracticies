namespace Pt02Builder.Chefs
{
    public class MasterChef
    {
        private AbstractChef _ukrainianChef;
        private AbstractChef _chinaChef;

        public MasterChef(AbstractChef ukrainianChef, AbstractChef chinaChef)
        {
            _ukrainianChef = ukrainianChef;
            _chinaChef = chinaChef;
        }

        public void ManageKitchen()
        {
            _ukrainianChef.AddFirstIngredient();
            _ukrainianChef.AddSecondIngredient();
            _ukrainianChef.AddThirdIngredient();

            _chinaChef.AddFirstIngredient();
            _chinaChef.AddSecondIngredient();
            _chinaChef.AddThirdIngredient();
        }
    }
}