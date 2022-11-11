using AWildSolutions.Zootah.GiftStore.API.Context;
using AWildSolutions.Zootah.GiftStore.API.Context.TableSets;
using AWildSolutions.Zootah.GiftStore.API.Interfaces;

namespace AWildSolutions.Zootah.GiftStore.API.Services;

public class ProductTypeService : IService
{
    private IRepository<ProductType> _repo;

    public ProductTypeService(IRepository<ProductType> repo)
    {
        _repo = repo;
    }

    public IEnumerable<ProductType> GetAllTypes() => _repo.GetAll();
}