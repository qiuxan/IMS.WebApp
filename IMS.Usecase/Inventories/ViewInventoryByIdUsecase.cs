using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.CoreBusiness;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories
{
    public class ViewInventoryByIdUsecase : IViewInventoryByIdUsecase
    {
        private readonly IInventoryRepository _inventoryRepository;
        public ViewInventoryByIdUsecase(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }
        public async Task<Inventory> ExecuteAsync(int inventoryId)
        {
            return await _inventoryRepository.GetInventoryByIdAsync(inventoryId);
        }
    }
}
