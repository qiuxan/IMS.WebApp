using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugings.InMemory;

public class InventoryRepository : IInventoryRepository
{
    private readonly List<Inventory> _inventories = new List<Inventory>();

    public InventoryRepository()
    {
        _inventories = new List<Inventory>()
        {
            new Inventory {InventoryId = 1, InventoryName = "bike seat", Quantity = 10, Price = 2},
            new Inventory {InventoryId = 2, InventoryName = "bike tire", Quantity = 20, Price = 5},
            new Inventory {InventoryId = 3, InventoryName = "bike frame", Quantity = 5, Price = 20},
            new Inventory {InventoryId = 4, InventoryName = "bike handlebar", Quantity = 15, Price = 10}, 
        };
    }
    public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
    {
        if(string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

        return await Task.FromResult(_inventories.Where(i => i.InventoryName.Contains(name)));
    }

    Task IInventoryRepository.AddInventoryAsync(Inventory inventory)
    {
        if (_inventories.Any(i =>
                i.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase)))
        {
            return Task.CompletedTask;
        }

        var maxId = _inventories.Max(i => i.InventoryId);
        inventory.InventoryId = maxId + 1;
        _inventories.Add(inventory);
        return Task.CompletedTask;
    }
}
