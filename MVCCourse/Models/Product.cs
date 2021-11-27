using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCourse.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name ="Descrição")]
        public string Description{ get; set; }
        [Range(1, 10, ErrorMessage = "Value out of range.")]
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category{ get; set; }
    }                                                                                                                           
}
