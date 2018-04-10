using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Diplomka.DataModel
{
    public class ua_translate
    {
        [Key]
        public int UkrainId { get; set; }
        public string Word { get; set; }
        public uk_translate English { get; set; }
    }
}