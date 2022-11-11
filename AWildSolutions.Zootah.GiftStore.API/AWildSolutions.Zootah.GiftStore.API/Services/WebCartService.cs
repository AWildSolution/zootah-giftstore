using AWildSolutions.Zootah.GiftStore.API.Context;
using AWildSolutions.Zootah.GiftStore.API.Context.TableSets;
using AWildSolutions.Zootah.GiftStore.API.Interfaces;

namespace AWildSolutions.Zootah.GiftStore.API.Services;

public class WebCartService : IService
{
    private WebCartContext _context;

    public WebCartService(WebCartContext context)
    {
        _context = context;
    }

    public WebCart GetWebCart(Guid id)
    {
        return _context.WebCart.FirstOrDefault(w => w.Id == id);
    }
}