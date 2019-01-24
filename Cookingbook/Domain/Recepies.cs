using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookingbook
{
    public class Recepies
    {
        public string Title { get; set; }
        public List<string> Steps { get; set; }

        public Recepies(string title, List<string> steps)
        {
            Title = title;
            Steps = steps;
        }
    }
}
