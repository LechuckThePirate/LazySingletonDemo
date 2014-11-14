using LazySingletonDemo.Interfaces;

namespace LazySingletonDemo.Classes 
{
    public class Country : IDemoEntity
    {
        public string Name { get; set; }

        public int NumCode { get; set; }
        public string Code { get; set; }

        string IDemoEntity.GetLabel()
        {
            return this.Name;
        }

        public Country(string name, int numCode, string code)
        {
            this.Name = name;
            this.NumCode = numCode;
            this.Code = code;
        }

    }
}
