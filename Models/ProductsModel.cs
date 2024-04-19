using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarkett_mvp.Models
{
    internal class ProductsModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Product name must be between 3 and 50 characters ")]
        public string Name { get; set; }

        [DisplayName("Product Observation")]
        [Required(ErrorMessage = "Product observation is required")]
        [StringLength(200, MinimumLength = 3,
            ErrorMessage = "Product observation must be between 3 and 200 characters ")]
        public string Observation { get; set; }
    }
}
