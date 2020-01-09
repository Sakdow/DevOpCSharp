using DataContrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesContracts
{
    public abstract class AbstractRecipesService
    {
        public abstract List<Recipe> GetRecipes();    }
}
