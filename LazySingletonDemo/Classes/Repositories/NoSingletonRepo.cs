using System;
using System.Linq;
using LazySingletonDemo.Interfaces;

namespace LazySingletonDemo.Classes.Repositories
{
    public class NoSingletonRepo : ISingletonRepository
    {
        public NoSingletonRepo()
        {
            Console.WriteLine(">>> new NoSingletonRepo()");
        }

        public IQueryable<Country> GetCountries()
        {
            return new Storage().GetCountries();
        }

        public IQueryable<Language> GetLanguages()
        {
            return new Storage().GetLanguages();
        }

    }
}
