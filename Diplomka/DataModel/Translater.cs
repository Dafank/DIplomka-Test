using System.Data.Entity;

namespace Diplomka.DataModel
{
    public class Translater:DbContext
    {
        public Translater() : base("name=Translater")//Зв'язання з БД
        {

        }

        public virtual DbSet<ua_translate> Ukrain { get; set; }//Модель українських слів
        public virtual DbSet<uk_translate> English { get; set; }//Модель англійських слів

    }
}