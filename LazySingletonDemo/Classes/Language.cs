using LazySingletonDemo.Interfaces;

namespace LazySingletonDemo.Classes
{
    public class Language : IDemoEntity
    {
        public string Name { get; set; }
        public string Locale { get; set; }
        public string Code { get; set; }

        string IDemoEntity.GetLabel()
        {
            return string.Format("{0} ({1}", this.Name,this.Locale );
        }

        public Language(string name, string locale, string code)
        {
            this.Name = name;
            this.Locale = locale;
            this.Code = code;
        }
    }
}
