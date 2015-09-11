using System.Collections.Generic;
using System.Text;

namespace Pt02Builder.Meal
{
    public class Soup : IMeal
    {
        List<string> inredients = new List<string>();

        public void AddInredients(string item)
        {
            inredients.Add(item);
        }

        public string GetResult()
        {
            var sb = new StringBuilder("Dish with inredients:");
            foreach (var inredient in inredients)
            {
                sb.AppendFormat(" {0},", inredient);
            }

            return sb.ToString();
        }
    }
}