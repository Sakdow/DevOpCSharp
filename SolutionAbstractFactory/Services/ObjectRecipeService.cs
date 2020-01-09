using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DataContrats;

namespace Services
{
    public class ObjectRecipeService : ServicesContracts.AbstractRecipesService
    {
        public override List<Recipe> GetRecipes()
        {
            return new List<Recipe>()
            {
                new Recipe() { Id = Guid.NewGuid(), Title="Recipe01" },
                new Recipe() { Id = Guid.NewGuid(), Title="Recipe02" },
                new Recipe() { Id = Guid.NewGuid(), Title="Recipe03" }
            };
        }
    }
}
