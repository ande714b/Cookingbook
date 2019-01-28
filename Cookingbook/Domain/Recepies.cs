using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookingbook
{
    public class Recepies
    {
        public string Title { get; private set; }
        public List<string> Steps { get; set; }

        public TimeSpan Time { get; set; }

        public Recepies(string title, List<string> steps, TimeSpan time)
        {
            Title = title;
            Steps = steps;
            Time = time;
        }
    }
}
