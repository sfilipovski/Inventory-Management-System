using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Domain.DomainModels
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public virtual IEnumerable<InventoryProducts> InventoryProducts { get; set; }
    }
}
