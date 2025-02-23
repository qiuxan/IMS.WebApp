using IMS.CoreBusiness;

namespace IMS.UseCases.Inventories.Interfaces;

public interface IViewInventoryByIdUsecase
{
    Task<Inventory> ExecuteAsync(int inventoryId);
}