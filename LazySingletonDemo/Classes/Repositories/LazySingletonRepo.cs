using System;
using System.Linq;
using LazySingletonDemo.Interfaces;

namespace LazySingletonDemo.Classes.Repositories
{
    public class LazySingletonRepo : ISingletonRepository
    {

        private static readonly Lazy<LazySingletonRepo> _instance = 
                        new Lazy<LazySingletonRepo>(() => new LazySingletonRepo());
        public static LazySingletonRepo Instance { get { return _instance.Value; } }

        private readonly Lazy<Storage> _storage = new Lazy<Storage>();
        private Storage Storage { get { return _storage.Value; } }
        
        public LazySingletonRepo()
        {
            Console.WriteLine(">>> new LazySingletonRepo()");
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
