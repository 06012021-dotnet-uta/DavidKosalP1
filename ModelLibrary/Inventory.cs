using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Inventory
    {
        
        [Display(Name = "Product")]
        public virtual int ProductID { get; set; }

        [ForeignKey("Product"), Column(Order = 0)]
        public virtual Product Products { get; set; }

        
        [Display(Name = "Location")]
        public virtual int LocationID { get; set; }
        [ForeignKey("Location"), Column(Order = 1)]
        public virtual Location Locations { get; set; } 

        public int NumberProducts { get; set; }
    }
}
