using System.Linq;
using Diplomka.DataModel;
using System.Data.Entity;
using System.Collections.Generic;


namespace Diplomka.Models
{
    public static class Translaters
    {

        public static List<string> SetData(string s)
        {
            List<string> ua_words = new List<string>();//Список українських слів
            Database.SetInitializer(new CreateDatabaseIfNotExists<Translater>());
            /*Перевірка чи БД існує, якщо ні то база створюється*/
            using (Translater db = new Translater())//Підключення до БД
            {
                db.Configuration.LazyLoadingEnabled = true;

                db.Ukrain.Load();
                var qwe = from p in db.Ukrain
                          where p.English.Word == s.ToLower()
                          select p;


                if (qwe != null)
                {
                    foreach (ua_translate item in qwe)
                    {
                        ua_words.Add(item.Word);
                    }
                }
                else
                {
                    ua_words.Add("Такого слова покіщо немає в нашій базі");
                }
            }
            return ua_words;
        }
    }
}