using AWildSolutions.Zootah.GiftStore.API.Context;
using AWildSolutions.Zootah.GiftStore.API.Context.TableSets;
using AWildSolutions.Zootah.GiftStore.API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AWildSolutions.Zootah.GiftStore.API.Services;

public class ProductService : IService
{
    private ProductContext _context;
    public ProductService(ProductContext context)
    {
        _context = context;
    }

    public List<Product> GetAllProducts()
    {
        return _context.Product.ToList();
    }

    public Product GetProduct(Guid id)
    {
        return _context.Product.FirstOrDefault(p => p.Id == id)!;
    }
    
}