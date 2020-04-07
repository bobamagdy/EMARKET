using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace E__Market.Models
{
    [MetadataType(typeof(ProductMetaDate))]
    public partial class Product

    {
        //add method or add new properties
    }
    public class ProductMetaDate
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Name Of Product")]
        public string name { get; set; }
        [Display(Name = "Price")]
        public Nullable<double> price { get; set; }
        [Display(Name = "Image")]
        public string image { get; set; }
        [Display(Name = "Description")]
        public string descroption { get; set; }
        [Display(Name = "Category")]
        public Nullable<int> category_id { get; set; }

        public virtual Category Category { get; set; }
    }
}