#region References

using LazySingletonDemo.Interfaces;

#endregion

namespace LazySingletonDemo.Classes.Demos
{
    public class CountryDemo : DemoRunner
    {

        public CountryDemo(ISingletonRepository repository) : base(repository) { }
        
        public override void Run()
        {
            RunDemo("Countries", Repository.GetCountries());
        }
    }
}
