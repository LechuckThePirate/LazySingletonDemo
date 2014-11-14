using System;
using System.Linq;
using LazySingletonDemo.Interfaces;

namespace LazySingletonDemo.Classes.Repositories
{
    public class SingletonRepo : ISingletonRepository
    {

        private static readonly SingletonRepo _instance = new SingletonRepo();
        public static SingletonRepo Instance  { get { return _instance; } }


        private static readonly Storage _storage = new Storage();
        protected static Storage Storage { get { return _storage; } }

        public SingletonRepo()
        {
            Console.WriteLine(">>> new SingletonRepo()");
        }

        public IQueryable<Country> GetCountries()
        {
            return Storage.GetCountries();
        }

        public IQueryable<Language> GetLanguages()
        {
            return Storage.GetLanguages();
        }
    }
}
