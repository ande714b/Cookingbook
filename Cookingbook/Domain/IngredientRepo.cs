using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookingbook.Domain
{
    class IngredientRepo
    {
       private List<Ingredient> ingredients = new List<Ingredient>();

        public IngredientRepo()
        {
            for (int i = 0; i < 3; i++)
            {
                ingredients.Add(new Ingredient("Ingredient " + i));
            }
        }

        public List<Ingredient> getingredients()
        {
            return ingredients;
        }
    }
}
