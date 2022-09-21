using Arsys.API.DTOs;

namespace Arsys.API.Services.CashDesk.Services.Interfaces;

public interface ICategoryService
{
    Task<ProductListViewModel> GetProducts(string category);
}