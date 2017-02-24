using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace product_manage
{
    public class Product
    {
        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]       
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string description { get; set; }
        [Required]
        public string HomePageUrl { get; set; }
        public List<UpdateProduct> updateproduct { get; set; }
    }
}
