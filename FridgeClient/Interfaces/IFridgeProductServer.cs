using Microsoft.AspNetCore.Mvc;
using RestEase;
using System.Threading.Tasks;
using System;
using FridgeClient.Models.DataTransferObjects;
using System.Collections;
using System.Collections.Generic;

namespace FridgeClient.Interfaces
{
    [Header("FridgeProduct-Agent", "RestEase")]
    public interface IFridgeProductServer
    {
        [Get("api/fridges/{fridgeId}/products")]
        
        Task<IEnumerable<ProductDto>> GetProductsForFridge([Path] Guid fridgeId);

        [Get("api/fridges/{fridgeId}/products/{id}")]
        Task<IActionResult> GetProductForFridge([Path] Guid fridgeId, [Path] Guid id);

        [Post("api/fridges/{fridgeId}/products/{id}")]
        Task<IActionResult> CreateProductForFridge([Path] Guid fridgeId, [Path] Guid id,
            [Body] FridgeProductForCreationDto fridgeProductForCreationDto);

        [Delete("api/fridgeProducts/{fridgeProductId}")]
        Task<IActionResult> DeleteProductForFridge([Path] Guid fridgeProductId);

        [Put("api/fridgeProducts/{fridgeProductId}")]
        Task<IActionResult> UpdateProductForFridge([Path] Guid fridgeProductId);
    }
}