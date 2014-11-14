using System.Linq;
using LazySingletonDemo.Classes;

namespace LazySingletonDemo.Interfaces
{
    public interface ISingletonRepository
    {
        IQueryable<Country> GetCountries();
        IQueryable<Language> GetLanguages();
    }
}
