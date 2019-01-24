using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookingbook.Domain
{
    class IngredientRepo
    {
        List<Ingredient> ingredients = new List<Ingredient>();

        public List<string> getingredients()
        {
            List<string> returnlist = new List<string>();

            for (int i = 0; i < 3; i++)
            {
                ingredients.Add(new Ingredient("Ingredient " + i));
            }

            foreach (var item in ingredients)
            {
                returnlist.Add(item.Name);
            }

            return returnlist;
        }
    }
}
