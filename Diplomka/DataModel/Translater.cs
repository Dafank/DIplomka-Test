using System.Data.Entity;

namespace Diplomka.DataModel
{
    public class Translater:DbContext
    {
        public Translater() : base("name=Translater")
        {

        }

        public virtual DbSet<ua_translate> Ukrain { get; set; }
        public virtual DbSet<uk_translate> English { get; set; }
    }
}