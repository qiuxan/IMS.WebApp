﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.CoreBusiness;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories;
public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
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
