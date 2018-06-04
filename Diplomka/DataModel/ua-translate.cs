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
        public int UkrainId { get; set; }// id елемента для подальшого зв'язування
        public string Word { get; set; }// українське слово
        public uk_translate English { get; set; }//Одне українське слово тільки до 1 англійського
    }
}