using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class Factory
    {
        static Factory()
        {
            // Lecture des paramètres
            var fileName = ConfigurationManager.AppSettings["AssemblyName"];
            var className = ConfigurationManager.AppSettings["ClassName"];

            // Création de l'instance et stockage
            Instance = (ServicesContracts.AbstractRecipesService)Activator.CreateInstance(fileName, className).Unwrap();

        }

        public static ServicesContracts.AbstractRecipesService Instance { get; set; }
    }
}
