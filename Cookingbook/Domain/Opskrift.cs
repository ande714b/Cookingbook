using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookingbook.Domain
{
    public class Opskrift
    {
        public string Title { get; set; }
        public List<Ingredient> ingredients { get; set; }

        public Opskrift(string title, List<Ingredient> ingredients)
        {
            Title = title;
            this.ingredients = ingredients;
        }
    }
}
