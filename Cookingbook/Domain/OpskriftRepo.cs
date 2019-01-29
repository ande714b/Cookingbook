using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookingbook.Domain
{
    public class OpskriftRepo
    {
        private List<Opskrift> opskrifts = new List<Opskrift>();
        private IngredientRepo ingredientRepo;

        public OpskriftRepo(IngredientRepo ingredientRepox)
        {
            ingredientRepo = ingredientRepox;
            createStandardOpskrift();
        }

        private void createStandardOpskrift()
        {
            Ingredient i1 = ingredientRepo.CreateNewIngredient("Kød");
            Ingredient i2 = ingredientRepo.CreateNewIngredient("Løg"); ;
            Ingredient i3 = ingredientRepo.CreateNewIngredient("Hakked tomater");

            List<Ingredient> toinsert = new List<Ingredient>();
            toinsert.Add(i1);
            toinsert.Add(i2);
            toinsert.Add(i3);
            List<Ingredient> toinsert2 = new List<Ingredient>();
            toinsert2.Add(i2);
            toinsert2.Add(i3);

            Opskrift o1 = new Opskrift("Kødsovs", toinsert);
            Opskrift o2 = new Opskrift("test2", toinsert2);

            opskrifts.Add(o1);
            opskrifts.Add(o2);
        }

        public List<Opskrift> GetOpskrifts()
        {
            return opskrifts;
        }
    }
}
