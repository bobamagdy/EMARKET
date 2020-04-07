using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace E__Market.Models
{
    [MetadataType(typeof(CategoryMetaDate))]
    public partial class Category

    {
        //add method or add new properties
    }

    public class CategoryMetaDate {
        [Display(Name = "ID")]

        public int Id { get; set; }
        [Display(Name = "Name of Category")]

        public string name { get; set; }
        [Display(Name = "Number Of Products")]

        public Nullable<int> num_of_producta { get; set; }
    }
}