using IMS.Domain.DomainModels;
using IMS.Repository.Implementation;
using IMS.Repository.Interface;
using IMS.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Service.Implementation
{
    public class InventoryServiceImpl : InventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryServiceImpl(IInventoryRepository _inventoryRepository)
        {
            this._inventoryRepository = _inventoryRepository;
        }
    }
}
