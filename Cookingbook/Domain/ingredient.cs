﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookingbook.Domain
{
    class Ingredient
    {
        public string Name { get; set; }

        public Ingredient(string name)
        {
            Name = name;
        }
    }
}
