using System.Linq;
using Diplomka.DataModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Collections.Generic;


namespace Diplomka.Models
{
    public static class Translaters
    {
        public static string SetData(string s)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<Translater>());
            string str = null;
            using (Translater db = new Translater())
            {
                db.Configuration.LazyLoadingEnabled = false;

                db.Ukrain.Load();
                var qwe = from p in db.Ukrain
                          where p.English.Word == s.ToLower()
                          select p;

                if (qwe != null)
                {
                    foreach (ua_translate item in qwe)
                    {
                        str += item.Word;
                    }
                }
                else
                {
                    str = "Такого слова покіщо немає в нашій базі";
                }
                                
            }
            return str;
        }

    }
        
}
