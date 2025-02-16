using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.CoreBusiness;
using IMS.Usecase.PluginInterfaces;

namespace IMS.Usecase.Inventories;
public class ViewInventoriesByNameUseCase
{
    private readonly IInventoryRepository inventoryRepository;

    public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
    {
        this.inventoryRepository = inventoryRepository;
    }

    // It is to present the list of inventories so the function return type is IEnumerable of Inventory
    public async Task<IEnumerable<Inventory>> ExcuteAsync(string name = "")
    {
        return await inventoryRepository.GetInventoriesByNameAsync(name);

    }
}
