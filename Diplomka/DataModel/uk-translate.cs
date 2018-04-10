using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Diplomka.DataModel
{
    public class uk_translate
    {
        [Key]
        public int EnglishId { get; set; }
        public string Word { get; set; }
        public string Description { get; set; }
        public ICollection<ua_translate> Ukrain { get; set; }

        public uk_translate()
        {
            Ukrain = new List<ua_translate>();
        }
    }
}