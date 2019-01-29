using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookingbook.Domain
{
    public class IngredientRepo
    {
        private List<Ingredient> ingredients = new List<Ingredient>();

        public IngredientRepo()
        {
            Createstandardingre();
        }

        private void Createstandardingre()
        {
            for (int i = 0; i < 3; i++)
            {
                ingredients.Add(new Ingredient("Ingredient " + i));
            }

            ingredients.Add(new Ingredient("Kød"));
        }

        public Ingredient CreateNewIngredient(string name)
        {
            return new Ingredient(name);
        }

        public List<Ingredient> getingredients()
        {
            return ingredients;
        }
    }
}
