using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookingbook.Domain
{
    public class RecepiesRepo
    {
        private List<Recepies> recepies = new List<Recepies>();
        

        public RecepiesRepo()
        {
            List<string> steps = new List<string> { "step 1", "step 2", "step 3" };
            TimeSpan span1 = TimeSpan.FromMinutes(40);
            TimeSpan span2 = TimeSpan.FromMinutes(30);
            TimeSpan span3 = TimeSpan.FromMinutes(15);

            Recepies test1 = new Recepies("Kødsovs", steps, span1);
            Recepies test2 = new Recepies("test1", steps, span2);
            Recepies test3 = new Recepies("test3", steps, span3);

            recepies.Add(test1);
            recepies.Add(test2);
            recepies.Add(test3);
        }

        public List<Recepies> CreateStandard()
        {
            return recepies;
        }
    }
}
