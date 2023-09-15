using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Domain.DomainModels
{
    public class InventoryProducts
    {
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
