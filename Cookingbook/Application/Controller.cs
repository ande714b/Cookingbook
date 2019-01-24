using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookingbook.Domain;

namespace Cookingbook.Application
{
    class Controller
    {
        RecepiesRepo recepiesRepo = new RecepiesRepo();
        IngredientRepo ingredientRepo = new IngredientRepo();
        public Dictionary<string, List<string>> getRecepies()
        {
            Dictionary<string, List<string>> returndic = new Dictionary<string, List<string>>();
            

            foreach (var item in recepiesRepo.CreateStandard())
            {
                returndic.Add(item.Title, item.Steps);
            }

            return returndic;
        }

        public List<string> getIngre()
        {
            return ingredientRepo.getingredients();
        }
    }
}
