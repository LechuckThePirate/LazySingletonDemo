using System;
using System.Collections.Generic;
using System.Linq;

namespace LazySingletonDemo.Classes
{
    public class Storage
    {
        public IQueryable<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country("Spain", 34, "ES"),
                new Country("France", 33, "FR"),
                new Country("Germany", 49, "DE"),
                new Country("United Kingdom",44,"UK")

            }.AsQueryable();
        }

        public IQueryable<Language> GetLanguages()
        {
            return new List<Language>
            {
                new Language("Español", "es-ES", "ES"),
                new Language("Français", "fr-FR", "FR"),
                new Language("Deustch", "de-DE", "DE"),
                new Language("English", "en-UK", "EN")
            }.AsQueryable();
        }

        public Storage()
        {
            Console.WriteLine(">>> new Storage()");
            Console.WriteLine();
        }
    }
}
