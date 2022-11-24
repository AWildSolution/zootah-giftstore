

namespace AWildSolutions.Zootah.GiftStore.API.Context.TableSets;

public class ShirtSizes
{
    public Guid Id { get; set; }
    public string Size { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}