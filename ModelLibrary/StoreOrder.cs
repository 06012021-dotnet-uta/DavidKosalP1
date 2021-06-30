using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class StoreOrder
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderTime { get; set; }

        [Display(Name = "Product")]
        public virtual int CustomerID { get; set; }
        [ForeignKey("Customer")]
        public virtual Customer Customers { get; set; }

        [Display(Name = "Location")]
        public virtual int LocationID { get; set; }
        [ForeignKey("Location")]
        public virtual Location Locations { get; set; }

    }
}
