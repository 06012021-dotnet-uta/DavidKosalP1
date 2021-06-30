using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class OrderDetails
    {
        
        [Display(Name = "StoreOrder")]
        public virtual int OrderID { get; set; }
        [ForeignKey("StoreOrder"), Column(Order = 0)]
        public virtual StoreOrder Orders { get; set; }

        [Display(Name = "Product")]
        public virtual int ProductID { get; set; }
        [ForeignKey("Product"), Column(Order = 1)]
        public virtual Product Products { get; set; }

        public int Quantity { get; set; }
    }
}
