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

        public OpskriftRepo()
        {
            Ingredient i1 = new Ingredient("kød");
            Ingredient i2 = new Ingredient("løg");
            Ingredient i3 = new Ingredient("rødløg");

            List<Ingredient> toinsert = new List<Ingredient>();
            toinsert.Add(i1);
            toinsert.Add(i2);
            toinsert.Add(i3);
            Opskrift o1 = new Opskrift("Kødsovs", toinsert);
            Opskrift o2 = new Opskrift("test2", toinsert);

            opskrifts.Add(o1);
            opskrifts.Add(o2);

        }

        public List<Opskrift> GetOpskrifts()
        {
            return opskrifts;
        }
    }
}
