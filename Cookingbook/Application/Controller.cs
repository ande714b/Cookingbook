using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookingbook.Domain;

namespace Cookingbook.Application
{
    public class Controller
    {
        private RecepiesRepo recepiesRepo;
        private IngredientRepo ingredientRepo;
        private OpskriftRepo opskriftRepo;


        public Controller()
        {
            recepiesRepo = new RecepiesRepo();
            ingredientRepo = new IngredientRepo();
            opskriftRepo = new OpskriftRepo(ingredientRepo);
        }

        public string getopskrifttitle(int i)
        {
            List<Opskrift> opskrifts = opskriftRepo.GetOpskrifts();
            return opskrifts[i].Title;
        }

        public List<string> getopskriftingredients(int i)
        {
            List<Opskrift> opskrifts = opskriftRepo.GetOpskrifts();
            List<Ingredient> ingre = opskrifts[i].ingredients;
            List<string> returnlist = new List<string>();

            foreach (var item in ingre)
            {
                returnlist.Add(item.Name);
            }
            return returnlist;
        }

        public string getrecepiestile(int i)
        {
            List<Recepies> recepies = recepiesRepo.CreateStandard();

            return recepies[i].Title;
        }

        public List<string> getrecepiesSteps(int value)
        {
            List<Recepies> recepies = recepiesRepo.CreateStandard();

            return recepies[value].Steps;
        }

        public TimeSpan getrecepiesTime(int value)
        {
            List<Recepies> recepies = recepiesRepo.CreateStandard();

            return recepies[value].Time;
        }

        public List<string> getIngredients()
        {
            List<string> returnlist = new List<string>();
            foreach (var item in ingredientRepo.getingredients())
            {
                returnlist.Add(item.Name);
            }

            return returnlist;
        }

        public bool checkifingredientIsInStock(string ingredient)
        {
            if (getIngredients().Contains(ingredient))
            {
                return true;
            }
            return false;
        }
    }
}
