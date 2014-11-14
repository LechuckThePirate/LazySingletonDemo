using System;
using System.Collections.Generic;
using System.Linq;
using LazySingletonDemo.Interfaces;

namespace LazySingletonDemo.Classes.Demos
{
    public abstract class DemoRunner
    {

        private readonly ISingletonRepository _repository;
        protected ISingletonRepository Repository
        {
            get { return _repository; }
        }

        public void RunDemo(string entityName, IEnumerable<IDemoEntity> entities)
        {
            //Console.WriteLine(">>>> Do " + entityName);
            var names = entities.OrderBy(e => e.Name).Select(e=> e.Name);
            Console.WriteLine("List of " + entityName);
            Console.WriteLine("-----------------" + "".PadLeft(entityName.Length, '-'));
            Console.WriteLine(string.Join(",", names));
            Console.WriteLine();
        }

        public abstract void Run();

        protected DemoRunner(ISingletonRepository repository)
        {
            _repository = repository;
        }
    }
}
