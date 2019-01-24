using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookingbook.Domain
{
    public class RecepiesRepo
    {
        List<Recepies> recepies = new List<Recepies>();
        List<string> steps = new List<string> {"step 1", "step 2", "step 3" };
        public List<Recepies> CreateStandard()
        {
            Recepies test1 = new Recepies("test1", steps);
            Recepies test2 = new Recepies("test2", steps);
            Recepies test3 = new Recepies("test3", steps);

            recepies.Add(test1);
            recepies.Add(test2);
            recepies.Add(test3);

            return recepies;


        }
    }
}
