using LazySingletonDemo.Classes.Demos;
using LazySingletonDemo.Interfaces;

namespace LazySingletonDemo.Classes
{
    public class LanguageDemo : DemoRunner
    {
        public LanguageDemo(ISingletonRepository repository) : base(repository) { }
        
        public override void Run()
        {
            RunDemo("Languages", Repository.GetLanguages());
        }
    }
}
